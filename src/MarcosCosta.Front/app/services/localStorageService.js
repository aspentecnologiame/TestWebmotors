(function () {
    'use strict';

    angular.module('webApp').service('localStorageService', localStorageService);

    localStorageService.$inject = ['$window'];

    function localStorageService($window) {

        var service = this;
        var userInfo;

        service.add = add;
        service.get = get;
        service.remove = remove;

        return service;

        function add(key, value) {
            $window.localStorage[key] = JSON.stringify(value);
        }

        function get(key) {
            return JSON.parse($window.localStorage[key]);
        }

        function remove(key) {
            $window.localStorage.removeItem(key);
        }
    }
})();