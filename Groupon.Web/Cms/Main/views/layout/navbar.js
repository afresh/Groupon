(function () {
    var controllerId = "cms.views.layout.navbar";
    angular.module("cms").controller(controllerId, [
        "$rootScope", "$state", "appSession", "abp.services.app.menuService",
        function ($rootScope, $state, appSession, menuService) {
            var vm = this;

            vm.menus = [];

            //vm.menu = abp.nav.menus.MainMenu;
            //vm.currentMenuName = $state.current.menu;

            function getCurrentMenus() {
                menuService.getCurrentMenus({}).success(function (result) {
                    if (result.code === 0) {
                        vm.menus = result.data;
                    } else {
                        abp.notify.error(App.localize(result.message));
                    }
                });
            }

            getCurrentMenus();

            $rootScope.$on("$stateChangeSuccess", function (event, toState, toParams, fromState, fromParams) {
                vm.currentMenuName = toState.menu;
            });

            vm.getShownUserName = function () {
                if (!abp.multiTenancy.isEnabled) {
                    return appSession.user.userName;
                } else {
                    if (appSession.tenant) {
                        return appSession.tenant.tenancyName + "\\" + appSession.user.userName;
                    } else {
                        return ".\\" + appSession.user.userName;
                    }
                }
            };
        }
    ]);
})();