(function () {

    'use strict';

    angular.module('webApp').service('searchZipCodeService', searchZipCodeService);

    searchZipCodeService.$inject = ['$http', '$q'];

    function searchZipCodeService($http, $q) {

        var service = this;
        setFunctions();
        return service;

        function setFunctions() {
            service.Search = search;
        }

        function search(cep) {

            var deferred = $q.defer();
            var url = 'https://viacep.com.br/ws/' + cep + '/json/';

            $http.get(url).then(function (response) {
                deferred.resolve(response);
            }, function (error) {
                deferred.reject(error);
            });

            return deferred.promise;

        }
    }

})();