(function() {
    angular.module("cms").controller("cms.views.tenants.index", [
        "$scope", "$modal", "abp.services.app.tenant",
        function ($scope, $modal, tenantService) {
            var vm = this;

            vm.tenants = [];

            function getTenants() {
                tenantService.getTenants({}).success(function (result) {
                    vm.tenants = result.items;
                });
            }

            vm.openTenantCreationModal = function() {
                var modalInstance = $modal.open({
                    templateUrl: "/Cms/Main/views/tenants/createModal.cshtml",
                    controller: "cms.views.tenants.createModal as vm",
                    backdrop: "static"
                });

                modalInstance.result.then(function () {
                    getTenants();
                });
            };

            getTenants();
        }
    ]);
})();