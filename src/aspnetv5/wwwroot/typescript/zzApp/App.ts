angular
    .module('typeScriptDemo', ["ngRoute"])
    .controller("mainPageController", ["$scope", TypeScriptDemoApp.Controllers.MainPageController])
    .controller("secondPageController", ["$scope", TypeScriptDemoApp.Controllers.SecondPageController])
    .config([
        '$routeProvider',
        ($routeProvider: ng.route.IRouteProvider) => {
            $routeProvider
                .when('/ts/page1', {
                templateUrl: 'TypescriptDemo/Page1Partial',
                    controller: 'mainPageController'
                })
                .when('/ts/page2', {
                templateUrl: 'TypescriptDemo/Page2Partial',
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