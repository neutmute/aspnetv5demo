angular
    .module('typeScriptDemo', ["ngRoute"])
    .controller("mainPageController", ["$scope", TypeScriptDemoApp.Controllers.MainPageController])
    .controller("secondPageController", ["$scope", TypeScriptDemoApp.Controllers.SecondPageController])
    .config([
        '$routeProvider',
        ($routeProvider: ng.route.IRouteProvider) => {
            $routeProvider
                .when('/mainPage', {
                    templateUrl: 'TypescriptDemo/MainPage',
                    controller: 'mainPageController'
                })
                .when('/secondPage', {
                templateUrl: 'TypescriptDemo/secondPage',
                    controller: 'secondPageController'
                })
                .otherwise({
                    redirectTo: '/'
                });
        }
    ])
    .config([
        '$locationProvider',
        ($locationProvider: ng.ILocationProvider) => {
            $locationProvider.html5Mode(true);
        }
    ]);