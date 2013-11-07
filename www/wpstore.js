    var exec = require('cordova/exec');

    var store_export = {};

    store_export.review = function (successCallback, errorCallback) {

        exec(function (res) {
            successCallback();
        }, errorCallback, "WPStore", "review", "");

    };

    store_export.isTrial = function (successCallback, errorCallback) {

        exec(function (res) {
            console.log("" + res);
            successCallback();
        }, errorCallback, "WPStore", "isTrial", "");

    };

    store_export.openStoreToBuyApp = function (successCallback, errorCallback) {

        exec(function (res) {
            var trialdata = JSON.parse(res);
            successCallback(trialdata);
        }, errorCallback, "WPStore", "openStoreToBuyApp", "");

    };

    module.exports = store_export;