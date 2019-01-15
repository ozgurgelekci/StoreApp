var orderUrl = "http://localhost:51247/api/orders/";

var getOrders = function () {
    sendRequest(orderUrl + "GetOrders",
        "GET",
        null,
        function (data) {
            model.orders.removeAll();
            model.orders.push.apply(model.orders, data);
        });
};

var deleteOrder = function (id) {
    sendRequest(orderUrl + "DeleteOrder" + "/" + id,
        "DELETE",
        null,
        function () {
            model.orders.remove(function (item) {
                return item.Id === id;
            })
        });
};

var saveOrder = function (order, successCallback) {
    sendRequest(orderUrl + "PostOrder",
        "POST",
        order,
        function () {
            getOrders();
            if (successCallback) {
                successCallback();
            }
        });
};