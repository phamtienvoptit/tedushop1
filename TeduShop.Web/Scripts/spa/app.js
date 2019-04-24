/// <reference path="../plugins/angular/angular.js" />

//Khai báo module
var myApp = angular.module('myModule', []);
myApp.controller("schoolController", schoolController);
myApp.service("Validator", Validator);
myApp.directive("teduShopDirective", teduShopDirective);
//myController.$inject = ['$scope'];
//Khai báo controller

schoolController.$inject = ['$scope','Validator']
function schoolController($scope, Validator) {

    $scope.checkNumber = function () {
        $scope.message = Validator.checkNumber($scope.num);
    }
    $scope.num=1;
}

function Validator($window) {
    return {
        checkNumber: checkNumber
    }
    function checkNumber(input) {
        if (input % 2 == 0) {
            return 'Đây là số chẵn';
        }
        else {
            return 'Đây là số lẻ';
        }
    }
}

function teduShopDirective() {
    return {
        restrict:"A",
        templateUrl: "/Scripts/spa/teduShopDirective.html"
    }
} 

