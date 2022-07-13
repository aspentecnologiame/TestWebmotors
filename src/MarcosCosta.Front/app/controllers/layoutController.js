(function () {

    'use strict';

    angular.module('webApp').controller('layoutController', layoutController);

    layoutController.$inject = ['$rootScope', 'layoutService'];

    function layoutController( $rootScope, layoutService) {

        var vm = this;
        validateToken();
        setProperties()
        setFunctions();
        
        return vm;

        function validateToken() {

            //layoutService.ValidateToken().then(function (response) {

            //}, function (error) {
            //    window.location.href = '../../';
            //});
        }

        function setProperties() {
            vm.Index = true;
            vm.BaseUrl = global.BaseUrl;
            $rootScope.loader = false;
        }

        function setFunctions() {
            vm.SetActive = setActive;
        }

        function setActive(li) {

            clearAll();

            switch (li) {
                case 'index':
                    vm.Index = true;
                    break;
            }
        }

        function clearAll() {
            vm.Index = false;
        }
    }

})();

