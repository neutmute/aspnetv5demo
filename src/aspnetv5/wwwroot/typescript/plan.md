# Typescript #


- Javascript
- Prototypal inheritance

Intellisense
.config([
        '$locationProvider',
        ($locationProvider) => {
            $locationProvider.html5Mode(true);
        }
]);

- Modularisation with namespaces
- Sourcemap debug

JS version

     vm.addNumbers = function (operand1, operand2) {
                alert(operand1 + operand2);
            };


	vm.addNumbers(12, 4);

TS version

        addNumbers(operand1, operand2) {
            alert(operand1 + operand2);
        }

        addNumbers(operand1: number, operand2: number) {
            alert(operand1 + operand2);
        }


CM2.0