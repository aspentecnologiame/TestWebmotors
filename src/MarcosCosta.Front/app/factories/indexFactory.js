(function () {

    'use strict';

    angular.module('webApp').factory('indexFactory', indexFactory);

    function indexFactory() {

        var factory = this;
        setProperties();
        return factory;

        function setProperties() {

            factory.ColumnDefs = [
                {
                    name: 'id',
                    type: 'number'
                },
                {
                    name: 'marca',
                },
                {
                    name: 'modelo',
                },
                {
                    name: 'versao',
                },
                {
                    name: 'ano',
                    type: 'number'
                },
                {
                    name: 'quilometragem',
                    type: 'number'
                },
                {
                    name: 'obserevacao',
                }
            ];
        }
    }

})();