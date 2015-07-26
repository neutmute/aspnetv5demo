/*
This file in the main entry point for defining grunt tasks and using grunt plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkID=513275&clcid=0x409
*/
module.exports = function (grunt) {
    grunt.loadNpmTasks('grunt-contrib-uglify');
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.loadNpmTasks("grunt-contrib-clean");
    grunt.loadNpmTasks("grunt-contrib-jshint");

    grunt.initConfig({
        uglify: {
            appTarget: {
                files: { 'wwwroot/app.js': ['Typescript/app.js'] }
            }
        },

        concat: {
            all: {
                src: ['TypeScript/app.js', 'TypeScript/Food.js'],
                dest: 'temp/combined.js'
            }
        },

        clean: ["wwwroot/app.js"],

        jshint: {
            files: ['Typescript/**/*.js'],
            options: {
                '-W069': false
            }
        },

        watch: {
            scripts: {
                files: ['Typescript/**/*.js'],
                tasks: ['uglify']
            }
        }
    });

    // define tasks
    grunt.registerTask('postBuild', ['clean', 'uglify', 'watch']);
};