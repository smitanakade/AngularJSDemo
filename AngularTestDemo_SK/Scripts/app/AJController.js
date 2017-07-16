angular.module('EmpAppAJ');
    EmpAppAJ.controller('EmpAJController', function ($scope, EmpAJServices) {
        $scope.AJEmployees = null;
        $scope.MessageAJ = "AJ Employee Details ";
        $scope.selected = [];

        GetAJCNTEmployee();
        //funciton for genrating all employees record
        function GetAJCNTEmployee() {
            debugger;
            var getRecord = EmpAJServices.GetEmployees();
            debugger;
            getRecord.then(function (emp) {
                $scope.AJEmployees = emp.data;
            }, function () {
                alert('Error');
            });

        }
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
        //select or deselect all check boxes using checkAll function
        $scope.checkAll = function () {
            if ($scope.selectAll) {
                angular.forEach($scope.AJEmployees, function (item) {
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

  
