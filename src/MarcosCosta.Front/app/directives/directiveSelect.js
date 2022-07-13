(function () {

    angular.module('webApp').directive('uiSelectWrap', uiSelectWrap);

    uiSelectWrap.$inject = ['$document', 'uiGridEditConstants'];

    function uiSelectWrap($document, uiGridEditConstants) {

        var directive = {};
        directive.link = link;
        return directive;

        function link($scope, $elm, $attr) {

            $document.on('click', docClick);

            function docClick(evt) {
                if ($(evt.target).closest('.ui-select-container').length === 0) {
                    $scope.$emit(uiGridEditConstants.events.END_CELL_EDIT);
                    $document.off('click', docClick);
                }
            }

        }
    }

})();