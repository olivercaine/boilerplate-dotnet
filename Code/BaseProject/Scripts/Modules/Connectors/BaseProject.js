var Connectors;
(function (Connectors) {
    var BaseProject = (function () {
        function BaseProject($http, config) {
            this.$http = $http;
            this.apiUrl = config["apiUrl"];
        }
        BaseProject.prototype.GetAllPhones = function (successCallback, errorCallback, finallyCallback) {
            this.$http.get(this.apiUrl + "/phones/getall").then(successCallback, errorCallback, finallyCallback);
        };
        return BaseProject;
    })();
    Connectors.BaseProject = BaseProject;
})(Connectors || (Connectors = {}));
