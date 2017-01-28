window.onerror = function (message, file, line) {
    console.log("Exception", file + "(" + line + "): " + message);
    _gaq.push(["_trackEvent", "Global", "Exception", file + "(" + line + "): " + message]);
}