var TrainModule = (function () {
    var options;

    function init(viewOptions) {
        options = {
            trainsTableId: viewOptions.trainsTableId,
            deleteButtonClass: viewOptions.deleteButtonClass,
            deleteTrainUrl: viewOptions.deleteTrainUrl
        };

        initHandlers();
    }
    

    function initHandlers() {

        $("." + options.deleteButtonClass).click(function () {
            $.ajax({
                type: "POST",
                url: options.deleteTrainUrl,
                data: {
                    trainId: 143
                }
            }).done(function (response) {
                debugger;


            });
        });
    }

    return {
        init: init
    }
})();