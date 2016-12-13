(function () {
    var controllerId = "cms.views.layout";
    angular.module("cms").controller(controllerId, [
        "$rootScope", "$scope", function ($rootScope, $scope) {
            var vm = this;

            $rootScope.isSidebarFull = true;

            $rootScope.changeSidebarFull = function() {
                $rootScope.isSidebarFull = !$rootScope.isSidebarFull;
            }
        }]);
})();