/// <binding BeforeBuild='preBuild' AfterBuild='postBuild' />

module.exports = function (grunt) {
    grunt.loadNpmTasks('grunt-contrib-uglify');
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.loadNpmTasks("grunt-contrib-clean");
    grunt.loadNpmTasks("grunt-contrib-jshint");
    grunt.loadNpmTasks("grunt-contrib-copy");
    grunt.loadNpmTasks("grunt-shell");

    grunt.initConfig({
        shell: {
            options: {
                stderr: false
            },
            steelcapPack: {
                command: 'echo "dnu pack ./../../lib/steelcap/src/steelcap"'
            },
            steelcapPackagelocal: {
                command: 'xcopy /y ./../../lib/steelcap/src/steelcap/bin/debug/*.nupkg ./../../packages-local'
            }
        },
        copy: {
            steelcapbins: {
                    cwd: './../../lib/steelcap/src/steelcap/bin/debug',
                    src: '**/*',
                    dest: './bin/debug',
                    expand:true
                    }
        }
    });

    grunt.registerTask('preBuild', []);
    grunt.registerTask('postBuild', ['copy:steelcapbins']);
};