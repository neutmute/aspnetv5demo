angular
    .module('typeScriptDemo', ["ngRoute", "tsDemo.OldSchool"])
   // .controller("mainPageController", ["$scope", TypeScriptDemoApp.Controllers.MainPageController])
    .controller("spicyControllerTs", ["$scope", TypeScriptDemoApp.Controllers.SpicyControllerTs])
    .controller("page3Controller", ["$scope", TypeScriptDemoApp.Controllers.Page3Controller])
    
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
                .when('/ts/page3', {
                    templateUrl: 'TypescriptDemo/Page3Partial',
                    controller: 'page3Controller',
                    controllerAs: 'vm'
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