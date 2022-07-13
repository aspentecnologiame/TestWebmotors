(function () {

    'use strict';

    /* App Module */

    var app = angular.module('webApp', [
        'ngRoute', 'ngAnimate', 'ngSanitize', 'ui.bootstrap', 'colorpicker.module',
        'ngTouch', 'ui.grid', 'ui.grid.edit', 'ui.grid.selection', 'ui.select',
        'ui.grid.pagination', 'ui.mask', 'rmDatepicker'
    ]);

    app.config(["rmDatepickerConfig", function (rmDatepickerConfig) {
        rmDatepickerConfig.mondayStart = true;
        rmDatepickerConfig.initState = "month";
    }]);

    app.config(['$routeProvider', '$locationProvider',
            function ($routeProvider, $locationProvider) {
            $locationProvider.hashPrefix('');
            $routeProvider.
                    when('/', {
                        templateUrl: global.BaseUrl + 'app/views/index.html',
                    });

            /************************************************************
                No IIS --- localhost
                when('/', {
                        templateUrl: '/app/views/main/main.html',

            *************************************************************

                No IIS --- localhost/meusite
                when('/meusite', {
                        templateUrl: '/meusite/app/views/main/main.html',

            *************************************************************/

            /*
                O codigo anterior era assim:
                function ($routeProvider, $locationProvider) {
                    $routeProvider.
                            when('/', {
                                templateUrl: '/app/views/main/main.html',
                                controller: 'mainController'
                            }).when('/Home', {
                                templateUrl: '/app/views/main/main.html',
                                controller: 'mainController'
                            }).when('/show', {
                                templateUrl: '/app/views/show/show.html',
                                controller: 'showController'
                            });

                Porém a controller era instanciada aqui e depois na view html
                <div ng-controller="mainController as main">
            */
            

            /*
                Para configurar o html5Mode, é necessário incluir a tag <system.webServer> no Web.Config
                Na _Layout.cshtml, é necessário incluir a tag <base href="/" /> na <Head></Head>
            */
            $locationProvider.html5Mode(true);
            //$locationProvider.html5Mode(false).hashPrefix('!');
            
        }])
        .config(function ($provide) {

            //Serve para pegar erro
            //Exemplo: esquecer de injetar algum arquivo

            $provide.decorator("$exceptionHandler", function () {
                return function (exception, cause) {
                    var errString = exception + ' - stack: ' + exception.stack + ' - cause: ' + cause;
                };
            });
        })
        .run(['$rootScope', function ($rootScope) {
            $rootScope.$on("$routeChangeSuccess", function (userInfo) {
                //console.log(userInfo);
            });
        }]);

}).call(this);
