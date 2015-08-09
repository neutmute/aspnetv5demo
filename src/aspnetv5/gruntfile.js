/// <binding BeforeBuild='preBuild' />
/*
This file in the main entry point for defining grunt tasks and using grunt plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkID=513275&clcid=0x409
*/
module.exports = function (grunt) {
    grunt.loadNpmTasks('grunt-contrib-uglify');
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.loadNpmTasks("grunt-contrib-clean");
    grunt.loadNpmTasks("grunt-contrib-jshint");
    grunt.loadNpmTasks("grunt-shell");

    grunt.initConfig({
        shell: {
            options: {
                stderr: false
            },
            steelcapPack: {
                command: 'echo "dnu pack .\\..\\..\\lib\\steelcap\\src\\steelcap"'
            },
            steelcapPackagelocal: {
                command: 'xcopy /y .\\..\\..\\lib\\steelcap\\src\\steelcap\\bin\\debug\\*.nupkg .\\..\\..\\packages-local'
            }
        }
    });

    grunt.registerTask('preBuild', ['shell:steelcapPack', 'shell:steelcapPackagelocal']);
};