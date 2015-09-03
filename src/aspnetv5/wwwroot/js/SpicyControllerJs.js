angular
    .module('tsDemo.OldSchool', [])
    .controller('spicyControllerJs', [
        '$scope', function($scope) {

            var vm = this;
            vm.spice = 'very';

            vm.chiliSpicy = function() {
                vm.spice = 'chili';
            };

            vm.jalapenoSpicy = function() {
                vm.spice = 'jalapeño';
            };
        }
    ]);