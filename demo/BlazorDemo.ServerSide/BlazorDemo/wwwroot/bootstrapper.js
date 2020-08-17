(function () {

    load("[as='script']", loadScriptResource)
        .then(() => getEventPromise(window, "load", "[as='style']", loadStylesheetResource));

    function getEventPromise(element, eventName, postfix, callback) {
        return new Promise(function (resolve) {
            element.addEventListener(eventName, eventHandler);
            function eventHandler() {
                element.removeEventListener(eventName, eventHandler);
                load(postfix, callback).then(resolve);
            }
        });
    }

    function load(postfix, callback) {
        var array = Array.prototype.slice.call(document.querySelectorAll(postfix));
        return Promise.all(array.map(callback));
    }
    function loadScriptResource(node) {
        return new Promise(function (resolve) {
            var element = document.createElement("script");
            element.src = node.href;
            for (var i = 0; i < node.attributes.length; i++) {
                var attribute = node.attributes[i];
                if (attribute.name === "href" || attribute.name === "rel" || attribute.name === "as")
                    continue;
                element.setAttribute(attribute.name, attribute.value);
            }
            element.onload = resolve;
            node.parentNode.appendChild(element);
        });
    }
    function loadStylesheetResource(element) {
        return new Promise(function (resolve) {
            element.onload = resolve;
            element.rel = "stylesheet";
        });
    }
})();
