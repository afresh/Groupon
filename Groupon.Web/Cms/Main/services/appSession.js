(function () {
    angular.module("cms").factory("appSession", [
            function () {

                var _session = {
                    user: null,
                    tenant: null
                };

                abp.services.app.session.getCurrentLoginInformations({ async: false }).done(function (result) {
                    _session.user = result.user;
                    _session.tenant = result.tenant;
                    _session.role = result.role;
                });

                return _session;
            }
        ]);
})();