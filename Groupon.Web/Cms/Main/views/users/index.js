(function() {
    angular.module("cms").controller("cms.views.users.index", [
        "$scope", "$modal", "abp.services.app.user",
        function ($scope, $modal, userService) {
            var vm = this;

            vm.users = [];

            function getUsers() {
                userService.getUsers({}).success(function (result) {
                    vm.users = result.items;
                });
            }

            vm.openUserCreationModal = function() {
                var modalInstance = $modal.open({
                    templateUrl: "/Cms/Main/views/users/createModal.cshtml",
                    controller: "cms.views.users.createModal as vm",
                    backdrop: "static"
                });

                modalInstance.result.then(function () {
                    getUsers();
                });
            };

            getUsers();
        }
    ]);
})();