angular
    .module('typeScriptDemo', ["ngRoute", "tsDemo.OldSchool"])
   // .controller("mainPageController", ["$scope", TypeScriptDemoApp.Controllers.MainPageController])
    .controller("spicyControllerTs", ["$scope", TypeScriptDemoApp.Controllers.SpicyControllerTs])
    
    .config([
        '$routeProvider',
        ($routeProvider: ng.route.IRouteProvider) => {
            $routeProvider
                .when('/ts/page1', {
                    templateUrl: 'TypescriptDemo/Page1Partial',
                    controller: 'spicyControllerJs',
                    controllerAs: 'vm'
                })
                .when('/ts/page2', {
                    templateUrl: 'TypescriptDemo/Page2Partial',
                    controller: 'spicyControllerTs',
                    controllerAs:'vm'
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