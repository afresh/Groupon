(function () {
    "use strict";
    
    var cms = angular.module("cms", [
        "ngAnimate",
        "ngSanitize",

        "ui.router",
        "ui.bootstrap",
        "ui.jq",

        "abp"
    ]);

    //Configuration for Angular UI routing.
    cms.config([
        "$stateProvider", "$urlRouterProvider",
        function($stateProvider, $urlRouterProvider) {
            $urlRouterProvider.otherwise("/");

            function setProvider(menu) {
                if (menu.templateUrl) {
                    if ("Home" === menu.url) {
                        $stateProvider
                            .state(menu.url, {
                                url: "/",
                                templateUrl: "/Cms/Main/views" + menu.templateUrl
                            });
                    } else {
                        $stateProvider
                            .state(menu.url, {
                                url: "/" + menu.url,
                                templateUrl: "/Cms/Main/views" + menu.templateUrl
                            });
                    }
                }
            }

            function getCurrentMenus() {
                $.ajax({
                    url: "/api/services/app/MenuService/GetCurrentMenus",
                    contentType: "application/json",
                    type: "post",
                    async: false,
                    data: {},
                    success: function (json) {
                        if (json.success && json.result) {
                            if (json.result.code === 0) {
                                $.each(json.result.data, function (index, menu) {
                                    setProvider(menu);
                                    $.each(menu.childMenus, function (childIndex, childMenu) {
                                        setProvider(childMenu);
                                    });
                                });
                            } else {
                                abp.notify.error(App.localize(json.result.message));
                            }
                        } else {
                            console.log("IMenuService-GetCurrentMenus:");
                            console.log(json);
                        }
                    }
                });
            }

            getCurrentMenus();

            //$stateProvider
            //    .state("home", {
            //        url: "/",
            //        templateUrl: "/Cms/Main/views/home/home.cshtml",
            //        menu: "Home" //Matches to name of 'Home' menu in GrouponNavigationProvider
            //    })
            //    .state("about", {
            //        url: "/about",
            //        templateUrl: "/Cms/Main/views/about/about.cshtml",
            //        menu: "About" //Matches to name of 'About' menu in GrouponNavigationProvider
            //    });
        }
    ]);
})();