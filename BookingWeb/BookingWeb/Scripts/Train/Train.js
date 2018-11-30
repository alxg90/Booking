var TrainModule = (function () {
    var options;
    var viewModel;

    function init(viewOptions) {
        options = {
            trainsTableId: viewOptions.trainsTableId,
            deleteButtonClass: viewOptions.deleteButtonClass,
            deleteTrainUrl: viewOptions.deleteTrainUrl
        };

        viewModel = new ViewModel(viewOptions.trains);
        ko.applyBindings(viewModel, $("#trains-container")[0]);
    }

    function ViewModel(trains) {
        var _this = this;

        _this.trains = ko.observableArray(trains);

        _this.onDeleteTrain = function(trainItem) {
            var isDelete = confirm("Ви впевнені, що хочете видалити потяг: " + trainItem.Name + " ?");
            if (!isDelete) {
                return;
            }

            $.ajax({
                type: "POST",
                url: options.deleteTrainUrl,
                data: {
                    number: trainItem.Number,
                    name: trainItem.Name
                }
            }).done(function (response) {
                viewModel.trains(response);
            });
        }
    }

    return {
        init: init
    }
})();