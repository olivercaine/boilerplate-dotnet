module Controllers {

    export interface IInfoScope extends ng.IScope {
        Phone: any;
        Phones: any;
        BaseprojectConnector: Connectors.BaseProject;
    }

    export function Info($scope: IInfoScope, $http: ng.IHttpService, $resource, baseprojectConnector: Connectors.BaseProject) {
        
        $scope.Phone = false;
        $scope.Phones = [];
        $scope.BaseprojectConnector = baseprojectConnector;

        var phone = $resource("/api/phones/:id", { id: "@id" });
        phone.get({ id: 2 }, response => {
            $scope.Phone = response;
        });

        $scope.BaseprojectConnector.GetAllPhones((response) => {
            $scope.Phones = response.data;
        }, null, null);

    }
}