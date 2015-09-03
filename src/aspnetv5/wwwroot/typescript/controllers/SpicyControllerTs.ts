module TypeScriptDemoApp.Controllers {

    export interface ISpicyControllerTs {
        spice: string;
        chiliSpicy(): void;
        jalapenoSpicy(): void;
    }

    export interface ISpicyControllerTsScope extends ng.IScope {
        vm: SpicyControllerTs;
    }

    export class SpicyControllerTs implements ISpicyControllerTs {
        
        spice: string;

        chiliSpicy(){
            this.spice = 'chili';
        }

        jalapenoSpicy()  {
            this.spice = 'jalapeño';
        }
    }
}