(function () {
    angular.module('fullhapp', [])
    .controller("HousesController", ['$scope', '$http', function ($scope, $http) {
        $scope.rejectHome = "";
        $http.get('api/homeapi').success(function (data) {
            $scope.sellers = data;
        });
        this.setHouseId = function (HomeID) {
            $scope.rejectHome = HomeID.toString();
        };
    }]);
})();
