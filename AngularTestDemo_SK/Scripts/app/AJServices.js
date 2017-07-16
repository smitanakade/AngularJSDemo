angular.module('EmpAppAJ');
EmpAppAJ.service('EmpAJServices', function ($http) {
    this.GetEmployees = function () {
        return $http.get('/EmployeeAJ/GetEmployees');
    };
});