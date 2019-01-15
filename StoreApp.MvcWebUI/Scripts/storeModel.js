var model = {
    products: ko.observableArray([]),
    categories: ko.observableArray([]),
    orders: ko.observableArray([]),
    error: ko.observable(""),
    isError: ko.observable(false)
};

$(document).ready(function () {

    ko.applyBindings();

    setDefaultCallbacks(function (data) {
        if (data) {
            console.log("Begin success");
            console.log(JSON.stringify(data));
            console.log("End Success");
        } else {
            console.log("success (veri yok)");
        }
        model.isError(false);
    },
        function (statusCode, statusText) {
        console.log("error : " + statusCode + "(" + statusText + ")");
        model.error(statusCode + " (" + statusText + ")");
        model.isError(true);
    });

});