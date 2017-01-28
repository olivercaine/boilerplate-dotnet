var Directives;
(function (Directives) {
    function PhoneAdvert() {
        return {
            scope: {
                viewmodel: "=viewmodel"
            },
            templateUrl: "/Partials/PhoneAdvert"
        };
    }
    Directives.PhoneAdvert = PhoneAdvert;
})(Directives || (Directives = {}));
