﻿var productUrl = "http://localhost:51247/api/products/";

var getProducts = function () {
    sendRequest(productUrl + "GetProducts",
        "GET",
        null,
        function (data) {
            model.products.removeAll();
            model.products.push.apply(model.products, data);
        });
};

var deleteProduct = function (id) {
    sendRequest(productUrl + "DeleteProduct" + "/" + id,
        "DELETE",
        null,
        function () {
            model.products.remove(function(item) {
                return item.Id === id;
            })
        });
};

var saveProduct = function (product, successCallback) {
    sendRequest(productUrl + "PostProduct",
        "POST",
        product,
        function () {
            getProducts();
            if (successCallback) {
                successCallback();
            }
        });
};