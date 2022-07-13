(function () {

    'use strict';

    angular.module('webApp').controller('indexController', indexController);

    //a service deve ser injetada aqui
    indexController.$inject = ['indexService', 'indexFactory', '$uibModal', '$scope', '$interval', '$rootScope', '$timeout'];

    function indexController(indexService, indexFactory, $uibModal, $scope, $interval, $rootScope, $timeout) {

        var vm = this;

        setFunctions();
        setProperties();
        startGrid();

        return vm;

        function setFunctions() {

            vm.OpenModal = openModal;
            vm.MarcaSelecionada = marcaSelecionada;
            vm.ModeloSelecionado = modeloSelecionado;
            vm.VersaoSelecionada = versaoSelecionada;

            vm.FullSearch = fullSearch;
            vm.ClearIndexFilter = clearIndexFilter;
            vm.ExecuteFilterGrid = executeFilterGrid;

            vm.Save = save;
        }

        function setProperties() {

            vm.items = ['Mensagem a ser mostrada!!'];

            $rootScope.loader = true;

            vm.Veiculo = {};

            vm.CallBackMessage = '';
            vm.ShowDivCallBackMessage = false;
            vm.CallBackSuccess = true;

            vm.FilterItem = '';
            vm.ColumnsFilter = new Array('name');
            vm.TextSearch = '';
        }

        function openModal(message, func) {

            vm.items = [];
            vm.items.push(message);
            vm.items.CallbackFunction = func;

            var modalInstance = $uibModal.open({
                animation: false,
                backdropClass: "transparence-backdrop",
                ariaLabelledBy: 'modal-title',
                ariaDescribedBy: 'modal-body',
                templateUrl: 'app/modal/confirm.html',
                controller: 'confirmController',
                controllerAs: '$ctrl',
                resolve: {
                    items: function () {
                        return vm.items;
                    }
                }
            });

            modalInstance.result.then(function (items) {

                $rootScope.loader = true;

                //INICIO da chamada do serviço POST

                vm.items.CallbackFunction();

                //FIM da chamada

            }, function (exception) {
                $rootScope.loader = false;
                vm.CallBackMessage = exception;
                vm.CallBackSuccess = false;
                vm.ShowDivCallBackMessage = true;
                $rootScope.loader = false;
            });

        }

        function startGrid() {

            vm.gridOptions = {
                rowHeight: 38,
                enableFullRowSelection: true,
                multiSelect: false,
                columnDefs: indexFactory.ColumnDefs
            };

            $rootScope.loader = true;

            indexService.GetAll().then(function (response) {

                var data = response.data;
                vm.gridOptions.data = data;

                indexService.GetMarcas().then(function (response) {

                    vm.Marcas = response.data;
                    $rootScope.loader = false;

                }, function (error) {
                    $rootScope.loader = false;
                    vm.CallBackMessage = error;
                    vm.CallBackSuccess = false;
                    vm.ShowDivCallBackMessage = true;
                });

              
            }, function (error) {
                $rootScope.loader = false;
                vm.CallBackMessage = error;
                vm.CallBackSuccess = false;
                vm.ShowDivCallBackMessage = true;
            });
 
        }

        function fullSearch() {

            vm.ColumnsFilter = [];

            indexFactory.ColumnDefs.forEach(function (column) {
                vm.ColumnsFilter.push(column.name);
            });

            vm.FilterItem = vm.TextSearch;

            refreshGrid();
        }

        function marcaSelecionada(item) {

            $rootScope.loader = true;

            indexService.GetModelos(item.id).then(function (response) {

                vm.Modelos = response.data;
                $rootScope.loader = false;

            }, function (error) {
                $rootScope.loader = false;
                vm.CallBackMessage = error;
                vm.CallBackSuccess = false;
                vm.ShowDivCallBackMessage = true;
            });

            vm.FilterItem = item.name;
            vm.ColumnsFilter = ['marca'];
            refreshGrid();
        }

        function modeloSelecionado(item) {

            $rootScope.loader = true;

            indexService.GetVersoes(item.id).then(function (response) {

                vm.Versoes = response.data;
                $rootScope.loader = false;

            }, function (error) {
                $rootScope.loader = false;
                vm.CallBackMessage = error;
                vm.CallBackSuccess = false;
                vm.ShowDivCallBackMessage = true;
            });
        }

        function versaoSelecionada(item) {

            var teste = item.name;
        }

        function refreshGrid() {
            vm.gridApi.grid.refresh();
        }

        function executeFilterGrid(renderableRows) {

            var matcher = new RegExp(String(vm.FilterItem).toLowerCase());

            renderableRows.forEach(function (row) {

                var match = false;

                vm.ColumnsFilter.forEach(function (field) {

                    if (row.entity[field] !== undefined && String(row.entity[field]).toLowerCase().match(matcher))
                        match = true;
                });

                if (!match)
                    row.visible = false;
            });

            return renderableRows;
        }

        function clearIndexFilter() {
            vm.ColumnsFilter = ['name'];
            vm.FilterItem = '';
            refreshGrid();
        }

        function save() {

            $rootScope.loader = true;

            indexService.Save(vm.Veiculo).then(function (response) {

                var data = response.data;

                indexService.GetAll().then(function (response) {

                    var data = response.data;
                    vm.gridOptions.data = data;
                    $rootScope.loader = false;

                }, function (error) {
                    $rootScope.loader = false;
                    vm.CallBackMessage = error;
                    vm.CallBackSuccess = false;
                    vm.ShowDivCallBackMessage = true;
                });

                vm.CallBackMessage = 'Dados do Veículo, salvos com sucesso!!'; 
                vm.CallBackSuccess = true;
                vm.ShowDivCallBackMessage = true;

            }, function (error) {
                $rootScope.loader = false;
                vm.CallBackMessage = error;
                vm.CallBackSuccess = false;
                vm.ShowDivCallBackMessage = true;
            });

            vm.FilterItem = '';
            vm.ColumnsFilter = ['marca'];
            refreshGrid();
        }
    }

})();

