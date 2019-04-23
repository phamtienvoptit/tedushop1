//Khai báo module
var myApp = angular.module('myModule', []);

myApp.controller("myController", myController);
myApp.controller("studentController", studentController);
myApp.controller("schoolController", schoolController);
//myController.$inject = ['$scope'];
//Khai báo controller
function myController($scope) {
    $scope.message = "This is my message from controller";
}

function studentController($scope) {
    $scope.message = "This is my message from student";
}

function schoolController($scope) {
    $scope.message = "Annount this my school";
}