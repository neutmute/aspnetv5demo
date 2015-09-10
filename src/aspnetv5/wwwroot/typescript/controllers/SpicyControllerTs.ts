module TypeScriptDemoApp.Controllers {

    export interface ISpicyControllerTs {
        spice: string;
        chiliSpicy(): void;
        jalapenoSpicy(): void;
    }
     
    export class SpicyControllerTs implements ISpicyControllerTs {
        
        spice: string;
        

        constructor() {
            this.spice = 'very';
        }

        chiliSpicy(){
            this.spice = 'chili';
        }

        jalapenoSpicy()  {
            this.spice = 'jalapeño';
        }
    }
}