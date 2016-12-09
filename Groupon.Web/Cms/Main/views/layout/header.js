(function () {
    var controllerId = "cms.views.layout.header";
    angular.module("cms").controller(controllerId, [
        "$rootScope", "$state", "appSession",
        function ($rootScope, $state, appSession) {
            var vm = this;

            //vm.languages = abp.localization.languages;
            //vm.currentLanguage = abp.localization.currentLanguage;

            abp.event.on("abp.notifications.received", function (userNotification) {
                abp.notifications.showUiNotifyForUserNotification(userNotification);
            });
        }
    ]);
})();