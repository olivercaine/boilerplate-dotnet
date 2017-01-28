document.getElementsByTagName("html")[0].setAttribute("ng-app", "Angular");
angular.module("Angular", ["ngResource", "ngSanitize"])
    .factory("config", function () { return { apiUrl: "/api" }; })
    .service("baseprojectConnector", Connectors.BaseProject)
    .directive("phoneAdvert", Directives.PhoneAdvert)
    .controller("infoController", Controllers.Info);
