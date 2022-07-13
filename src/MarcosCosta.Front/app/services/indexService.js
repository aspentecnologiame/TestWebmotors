(function () {

    'use strict';

    angular.module('webApp').service('indexService', indexService);

    indexService.$inject = ['$http', '$q'];

    function indexService($http, $q) {

        var service = this;
        setFunctions();
        return service;

        function setFunctions() {
            service.GetAll = getAll;
            service.Save = save;

            service.GetMarcas = getMarcas;
            service.GetModelos = getModelos;
            service.GetVersoes = getVersoes;
        }

        function getAll() {

            var deferred = $q.defer();

            var url = 'anunciowebmotors';
            var verb = 'GET';

            var request = global.CreateRequest(url, verb);

            $http(request)
                .then(getAllSuccess)
                .catch(getAllFailed);

            function getAllSuccess(response) {
                deferred.resolve(response.data);
            }

            function getAllFailed(error) {
                deferred.reject(error.data);
            }

            return deferred.promise;
        }

        function getMarcas() {

            var deferred = $q.defer();

            var url = 'veiculo/marcas';
            var verb = 'GET';

            var request = global.CreateRequest(url, verb);

            $http(request)
                .then(getMarcasSuccess)
                .catch(getMarcasFailed);

            function getMarcasSuccess(response) {
                deferred.resolve(response.data);
            }

            function getMarcasFailed(error) {
                deferred.reject(error.data);
            }

            return deferred.promise;
        }

        function getModelos(makeId) {

            var deferred = $q.defer();

            var url = 'veiculo/modelos?makeId=' + makeId;
            var verb = 'GET';

            var request = global.CreateRequest(url, verb);

            $http(request)
                .then(getModelosSuccess)
                .catch(getModelosFailed);

            function getModelosSuccess(response) {
                deferred.resolve(response.data);
            }

            function getModelosFailed(error) {
                deferred.reject(error.data);
            }

            return deferred.promise;
        }

        function getVersoes(modelId) {

            var deferred = $q.defer();

            var url = 'veiculo/versoes?modelId=' + modelId;
            var verb = 'GET';

            var request = global.CreateRequest(url, verb);

            $http(request)
                .then(getVersoesSuccess)
                .catch(getVersoesFailed);

            function getVersoesSuccess(response) {
                deferred.resolve(response.data);
            }

            function getVersoesFailed(error) {
                deferred.reject(error.data);
            }

            return deferred.promise;
        }

        function save(veiculo) {

            var deferred = $q.defer();

            var url = 'anunciowebmotors';
            var verb = veiculo.id === undefined ? 'POST' : 'PUT';
            var data = veiculo;

            var request = global.CreateRequest(url, verb, data);

            $http(request)
                .then(saveSuccess)
                .catch(saveFailed);

            function saveSuccess(response) {
                deferred.resolve(response.data);
            }

            function saveFailed(error) {
                deferred.reject(error.data);
            }

            return deferred.promise;
        }
    }

})();