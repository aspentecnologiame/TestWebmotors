(function () {

    angular.module('webApp').controller('confirmController', confirmController);

    confirmController.$inject = ['$uibModalInstance', 'items'];

    function confirmController($uibModalInstance, items) {

        var $ctrl = this;
        $ctrl.items = items;

        $ctrl.ok = function () {
            $uibModalInstance.close(items);
        };

        $ctrl.cancel = function () {
            $uibModalInstance.dismiss('cancel');
        };
    }

})();