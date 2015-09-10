module TypeScriptDemoApp.Controllers {

    export interface IMainPageController {
    }
    

    export class Page3Controller  {
        
        person : Models.IPerson;

        constructor(){
            console.log("Page3Controller constructed");

            this.person = <Models.IPerson>{firstName:"foo"};
        }

        sayHello() {
            alert("Hello " + this.person.firstName);
        }
    }
}




/*
new Models.Knight();


alert("Hello " + this.person.getTitle() + " " + this.person.firstName);
*/