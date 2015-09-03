angular
    .module('tsDemo.OldSchool', [])
    .controller('SpicyControllerJs', ['$scope', function ($scope) {
    $scope.spice = 'very';

    $scope.chiliSpicy = function () {
        $scope.spice = 'chili';
    };

    $scope.jalapenoSpicy = function () {
        $scope.spice = 'jalapeño';
    };
}])