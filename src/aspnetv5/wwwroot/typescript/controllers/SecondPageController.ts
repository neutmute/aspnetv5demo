module TypeScriptDemoApp.Controllers {

    export interface ISecondPageController {
    }

    export interface ISecondPageControllerScope extends ng.IScope {
        vm: SecondPageController;
    }

    export class SecondPageController implements ISecondPageController {

        static $inject = [
            '$scope'
        ];

        constructor(
            private $scope: ISecondPageControllerScope) {

            console.log("SecondPage controller controller constructed");
        }
    }
}