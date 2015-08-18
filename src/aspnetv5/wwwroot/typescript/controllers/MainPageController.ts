module TypeScriptDemoApp.Controllers {

    export interface IMainPageController {
    }

    export interface IMainPageControllerScope extends ng.IScope {
        vm: MainPageController;
    }

    export class MainPageController implements IMainPageController {

        static $inject = [
            '$scope'
        ];

        constructor(
            private $scope: IMainPageControllerScope) {

            console.log("MainPage controller controller constructed");
        }
    }
}