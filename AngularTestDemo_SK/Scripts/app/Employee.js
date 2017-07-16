var EmpApp = angular.module('EmpApp', []);
EmpApp.controller('EmpAppController', function ($scope, EmpService) {
    $scope.Employees = null;
    $scope.selected = [];
    $scope.Message = "Employee Records";

    EmpService.GetPesrons().then(function (d) {
        $scope.Employees = d.data;
    }, function () {
        alert('Error');
    });
    

    $scope.exist = function (item) {

        return $scope.selected.indexOf(item) > -1;
    }

    $scope.toggleSelection = function (item) {
        var idx = $scope.selected.indexOf(item);
        if (idx > -1) {
            $scope.selected.splice(idx, 1);
        }
        else {
            $scope.selected.push(item);
        }
    }
    //check all check boxes using checkAll function
    $scope.checkAll = function () {
        if ($scope.selectAll) {
            angular.forEach($scope.Employees, function (item) {
                idx = $scope.selected.indexOf(item);
                if (idx >= 0) {
                    return true;
                }
                else {
                    $scope.selected.push(item);
                }
            })
        }
        else {
            $scope.selected = [];

        }
    }
});

EmpApp.factory('EmpService', function ($http) {
    var fac = {};
    fac.GetPesrons = function () {
        return $http.get('/Home/GetPesrons')
    }
    return fac;
});



