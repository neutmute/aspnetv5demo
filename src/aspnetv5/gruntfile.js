/// <binding BeforeBuild='preBuild' AfterBuild='postBuild' ProjectOpened='projectOpen' />

module.exports = function (grunt) {
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.loadNpmTasks("grunt-contrib-copy");
    grunt.loadNpmTasks("grunt-shell");
    grunt.loadNpmTasks("grunt-typescript");
    grunt.loadNpmTasks("grunt-tsd");

    grunt.initConfig({

        typescript: {
            typeScriptDemo: {
                src: ['wwwroot/typescript/**/*.ts'],
                dest: 'wwwroot/assets/app-ts.js',
                options: {
                    module: 'amd', //or commonjs 
                    target: 'es5', //or es3
                    sourceMap: true,
                    declaration: false
                }
            }
        },

        tsd: {
            refresh: {
                options: {
                    command: 'reinstall',
                    latest: false,
                    config: 'tsd.json',
                    // experimental: options to pass to tsd.API
                    opts: {
                        // props from tsd.Options                    
                    }
                }
            }
        },

        watch: {
            typescript: {
                files: ['wwwroot/typescript/**/*.ts'],
                tasks: ['typescript']
            }
        },

        shell: {
            options: {
                stderr: false
            },

            steelcapPack: {
                command: 'echo "dnu pack ./../../lib/steelcap/src/steelcap"'
            }
        },

        copy: {
            steelcapbins: {
                    cwd: './../../lib/steelcap/src/steelcap/bin/debug',
                    src: '**/*',
                    dest: './bin/debug',
                    expand:true
            },
            
            bowerDist: {
                src: 'bower_components/**/dist/*',
                dest: 'wwwroot/assets/',
                expand: true,
                flatten: false
            },

            bowerAngular: {
                src: 'bower_components/angular*/angular*.js',
                dest: 'wwwroot/assets/',
                expand: true,
                flatten: false
            }
        }
    });

    grunt.registerTask('preBuild', []);
    grunt.registerTask('postBuild', ['copy:steelcapbins']);
    grunt.registerTask('projectOpen', ['tsd', 'typescript', 'watch']);
};