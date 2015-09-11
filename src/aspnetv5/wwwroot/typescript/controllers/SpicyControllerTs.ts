module TypeScriptDemoApp.Controllers {
    
    export class SpicyControllerTs  {
        
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