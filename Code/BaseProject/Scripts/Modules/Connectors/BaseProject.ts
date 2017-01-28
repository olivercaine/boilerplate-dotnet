module Connectors {

    export interface IBaseProject {
        GetAllPhones(successCallback: Function, errorCallback: Function, finallyCallback: Function);
    }

    export class BaseProject implements IBaseProject {

        private $http: ng.IHttpService;
        private apiUrl: string;

        constructor($http: ng.IHttpService, config: Object) {
            this.$http = $http;
            this.apiUrl = config["apiUrl"];
        }

        GetAllPhones(successCallback, errorCallback, finallyCallback) {
            this.$http.get(this.apiUrl + "/phones/getall").then(successCallback, errorCallback, finallyCallback);
        }

    }
} 