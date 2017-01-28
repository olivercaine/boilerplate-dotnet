angular.module("Angular", ["ngResource", "ngSanitize"])
    .factory("config", function () { return { apiUrl: "/api" }; })
    .service("baseprojectConnector", Connectors.BaseProject)
    .directive("phoneAdvert", Directives.PhoneAdvert)
    .controller("infoController", Controllers.Info);
