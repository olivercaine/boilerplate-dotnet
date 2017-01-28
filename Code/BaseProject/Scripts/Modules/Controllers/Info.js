var Controllers;
(function (Controllers) {
    function Info($scope, $http, $resource, baseprojectConnector) {
        $scope.Phone = false;
        $scope.Phones = [];
        $scope.BaseprojectConnector = baseprojectConnector;
        var phone = $resource("/api/phones/:id", { id: "@id" });
        phone.get({ id: 2 }, function (response) {
            $scope.Phone = response;
        });
        $scope.BaseprojectConnector.GetAllPhones(function (response) {
            $scope.Phones = response.data;
        }, null, null);
    }
    Controllers.Info = Info;
})(Controllers || (Controllers = {}));
