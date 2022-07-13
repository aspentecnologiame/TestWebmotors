(function () {

    'use strict';

    angular.module('webApp').filter('brlCurrency', ['$filter', brlCurrencyFilter]);

    function brlCurrencyFilter($filter) {

        return function (amount, symbol, precision) {
            symbol = symbol ? [symbol, ''].join(' ') : '';
            precision = precision ? precision : 2;
            amount = $filter('currency')(amount, symbol, precision);
            return amount
                .replace(/\./g, 'DECIMAL')
                .replace(/,/g, '.')
                .replace(/DECIMAL/g, ',');
        };

    }

}());