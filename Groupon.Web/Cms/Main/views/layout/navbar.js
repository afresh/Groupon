(function () {
    var controllerId = "cms.views.layout.navbar";
    angular.module("cms").controller(controllerId, [
        "$rootScope", "$scope", "$state", "appSession", "abp.services.app.menuService",
        function ($rootScope, $scope, $state, appSession, menuService) {
            var vm = this;

            vm.menus = [];
            vm.currentMenu = {};
            vm.currentMenu.childMenus = [];

            vm.currentMenuName = $state.current.name;

            function getCurrentMenus() {
                menuService.getCurrentMenus({ async: false }).success(function (result) {
                    if (result.code === 0) {
                        vm.menus = result.data;
                        $.each(vm.menus, function (index, menu) {
                            if (vm.currentMenuName === menu.url) {
                                menu.isChosed = true;
                            } else if ("Home" === menu.url) {
                                menu.isChosed = true;
                            }
                            if ("Home" === menu.url) {
                                menu.url = "/";
                            }
                        });
                    } else {
                        abp.notify.error(App.localize(result.message));
                    }
                });
            }

            getCurrentMenus();

            $scope.chooseMenu = function (item) {
                $.each(vm.menus, function (index, menu) {
                    menu.isChosed = false;
                });
                vm.currentMenu = item;
                if (item.childMenus.length > 0) {
                    $scope.chooseChildMenu(item.childMenus[0]);
                }
                item.isChosed = true;
            };

            $scope.chooseChildMenu = function (item) {
                $.each(vm.currentMenu.childMenus, function (index, menu) {
                    menu.isChosed = false;
                });
                item.isChosed = true;
            };

            $rootScope.setPageSize = function() {
                if ($rootScope.isSidebarFull && vm.currentMenu.childMenus.length > 0) {
                    return "viewFramework-page-full-show";
                } else if ($rootScope.isSidebarFull && vm.currentMenu.childMenus.length === 0) {
                    return "viewFramework-page-full-hide";
                } else if (!$rootScope.isSidebarFull && vm.currentMenu.childMenus.length > 0) {
                    return "viewFramework-page-mini-show";
                } else if (!$rootScope.isSidebarFull && vm.currentMenu.childMenus.length === 0) {
                    return "viewFramework-page-mini-hide";
                }
            }

            $rootScope.$on("$stateChangeSuccess", function (event, toState, toParams, fromState, fromParams) {
                vm.currentMenuName = toState.menu;
            });

            vm.getShownUserName = function () {
                vm.face = appSession.user.face ? appSession.user.face : "/Cms/Main/images/user1-128x128.jpg";
                vm.sex = appSession.user.sex === 0 ? "fa fa-male text-primary" : "fa fa-female text-primary";
                vm.role = appSession.role ? appSession.role.displayName : "游客";
                if (!abp.multiTenancy.isEnabled) {
                    return appSession.user.userName;
                } else {
                    if (appSession.tenant) {
                        return appSession.tenant.tenancyName + "\\" + appSession.user.userName;
                    } else {
                        return appSession.user.userName;
                    }
                }
            };
        }
    ]);
})();