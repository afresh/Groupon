(function () {
    angular.module("cms").directive("autoFocus", function () {
          return {
              restrict: "A",
              link: function ($scope, element) {
                  element[0].focus();
              }
          };
      });
})();