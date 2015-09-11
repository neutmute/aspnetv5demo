# Typescript #

* http://www.davideaversa.it/wp-content/uploads/2015/04/199aff3.jpg
* http://blogs.msdn.com/b/typescript/archive/2015/03/05/angular-2-0-built-on-typescript.aspx
* https://docs.angularjs.org/guide/controller

- Compare Js vs Ts controller
- Compare Js vs Ts view partials
- Observe module, resultant code
- Run the code
- Sourcemap debug
- Observe Intellisense on $locationProvider
- tsd typings (http://definitelytyped.org/)
- Typing JS version

	     vm.addNumbers = function (operand1, operand2) {
	                alert(operand1 + operand2);
	            };


		vm.addNumbers(12, 4);

- Typing TS version

        addNumbers(operand1, operand2) {
            alert(operand1 + operand2);
        }

        addNumbers(operand1: number, operand2: number) {
            alert(operand1 + operand2);
        }

- Prototypal inheritance


	    export class Person implements IPerson {
	
	        firstName: string;
	        lastName: string;
	        email: string;
	        address: IAddress;
	
	        getTitle(): string {
	            return "Mr";
	        }
	    }
	
	    export class Knight extends Person{
	        getTitle(): string {
	            return "Sir";
	        }
	    }



		new Models.Person();
		
		
		alert("Hello " + this.person.getTitle() + " " + this.person.firstName);
 

http://cdn.meme.am/instances/60658776.jpg
