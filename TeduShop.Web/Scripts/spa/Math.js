/// <reference path="../plugins/angular/angular.js" />

var myApp = angular.module('Math', []);
myApp.service('PhepToan', PhepToan);
myApp.controller('TinhToanController', TinhToanController);

function TinhToanController($scope, PhepToan) {
    $scope.PhepCong = function () {
        $scope.message = PhepToan.PhepCong($scope.numa, $scope.numb);
    }
    $scope.numa = 1;
    $scope.numb = 1;
    $scope.PhepTru = function () {
        $scope.message = PhepToan.PhepTru($scope.numa, $scope.numb);
    }
    $scope.PhepNhan = function () {
        $scope.message = PhepToan.PhepNhan($scope.numa, $scope.numb);
    }
    $scope.PhepChia = function () {
        $scope.message = PhepToan.PhepChia($scope.numa, $scope.numb);
    }
}

function PhepToan($window) {
    return {
        PhepCong: PhepCong,
        PhepTru: PhepTru,
        PhepNhan: PhepNhan,
        PhepChia: PhepChia,
    }
    function PhepCong(a, b) {
        $window.alert('Tổng là: '+ (a + b));
    }
    function PhepTru(a, b) {
        return a - b;
    }
    function PhepNhan(a, b) {
        return a * b;
    }
    function PhepChia(a, b) {
        if (b == 0) {
            return 'Số b không thể bằng 0';
        }
        else 
            return a / b;
    }
}