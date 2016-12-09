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

            if (abp.auth.hasPermission("Pages.Users")) {
                $stateProvider
                    .state("users", {
                        url: "/users",
                        templateUrl: "/Cms/Main/views/users/index.cshtml",
                        menu: "Users" //Matches to name of 'Users' menu in GrouponNavigationProvider
                    });
                $urlRouterProvider.otherwise("/users");
            }

            if (abp.auth.hasPermission("Pages.Tenants")) {
                $stateProvider
                    .state("tenants", {
                        url: "/tenants",
                        templateUrl: "/Cms/Main/views/tenants/index.cshtml",
                        menu: "Tenants" //Matches to name of 'Tenants' menu in GrouponNavigationProvider
                    });
                $urlRouterProvider.otherwise("/tenants");
            }

            $stateProvider
                .state("home", {
                    url: "/",
                    templateUrl: "/Cms/Main/views/home/home.cshtml",
                    menu: "Home" //Matches to name of 'Home' menu in GrouponNavigationProvider
                })
                .state("about", {
                    url: "/about",
                    templateUrl: "/Cms/Main/views/about/about.cshtml",
                    menu: "About" //Matches to name of 'About' menu in GrouponNavigationProvider
                });
        }
    ]);
})();