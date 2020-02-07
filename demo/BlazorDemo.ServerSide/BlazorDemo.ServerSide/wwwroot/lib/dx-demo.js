(function () {
    hljs.initHighlightingOnLoad();
    function HighlightJSUpdate() {
        window.setTimeout(function () {
            Array.prototype.slice.call(document.querySelectorAll('pre code')).forEach(function (block) {
                if (block["highlighted"]) return;
                block["highlighted"] = true;
                hljs.highlightBlock(block);
            });
        }, 0);
    }

    function ChangeSnippet(snippet, newText) {
        snippet.innerHTML = null;
        snippet.innerText = newText;
        hljs.highlightBlock(snippet);
        snippet["highlighted"] = true;
    }

    function ScrollToTarget(targetSelector) {
        var selector = targetSelector ? targetSelector : document.location.hash;
        var scrollToTargetCore = function () {
            if (selector) {
                var targetElement = document.querySelector(selector);
                if (targetElement) {
                    var docElement = document.documentElement;
                    var scrollY = targetElement.getBoundingClientRect().top + window.pageYOffset;
                    if (docElement.clientTop)
                        scrollY -= docElement.clientTop;
                    var topPanel = document.querySelector(".top-row");
                    var topFixedPanelHeight = window.getComputedStyle(topPanel, null).position == "fixed" ? topPanel.offsetHeight : 0;
                    scrollY -= topFixedPanelHeight;
                    if (window.pageYOffset != parseInt(scrollY))
                        window.scroll(0, scrollY);
                }
            } else {
                window.scroll(0, 0);
            }
        };
        var pendingStyleSheets = Array.from(document.head.querySelectorAll("link")).filter(function (l) {
            var isLoaded = !!l.sheet;
            if (isLoaded) {
                try {
                    if (Array.from(l.sheet.rules).filter(function (r) { return r.href && !r.styleSheet; }).length)
                        isLoaded = false;
                }
                catch (e) { }
            }
            return !isLoaded;
        });
        if (pendingStyleSheets.length)
            pendingStyleSheets.forEach(function (l) { return l.addEventListener("load", scrollToTargetCore, { once: true }); });
        else
            scrollToTargetCore();
    }

    var activeWidgets = [];
    function ScrollViewInit(scrollContainer) {
        var index = activeWidgets.indexOf(scrollContainer);
        if (index !== -1)
            return;

        activeWidgets.push(scrollContainer);
        new window.DevExpress.ui.dxScrollView(scrollContainer, {});
    }

    window.HighlightJSUpdate = HighlightJSUpdate;
    window.ChangeSnippet = ChangeSnippet;
    window.ScrollToTarget = ScrollToTarget;
    window.ScrollViewInit = ScrollViewInit;
})();