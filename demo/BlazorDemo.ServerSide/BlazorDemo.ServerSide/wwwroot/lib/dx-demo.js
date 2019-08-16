hljs.initHighlightingOnLoad();
function HighlightJSUpdate() {
    document.querySelectorAll('pre code').forEach((block) => {
        hljs.highlightBlock(block);
    });
}

function ScrollToTarget(targetSelector) {
    var selector = targetSelector ? targetSelector : document.location.hash;
    var scrollToTargetCore = () => {
        if(selector) {
            var targetElement = document.querySelector(selector);
            if (targetElement) {
                var docElement = document.documentElement;
                var scrollY = targetElement.getBoundingClientRect().top + window.pageYOffset;
                if (docElement.clientTop)
                    scrollY -= docElement.clientTop;
                var topFixedPanelHeight = document.querySelector(".main .top-row").offsetHeight;
                scrollY -= topFixedPanelHeight;
                if (window.pageYOffset != parseInt(scrollY))
                    window.scroll(0, scrollY);
            }
        } else {
            window.scroll(0, 0);
        }
    };
    var pendingStyleSheets = Array.from(document.head.querySelectorAll("link")).filter((l) => {
        var isLoaded = !!l.sheet;
        if(isLoaded) {
            try {
                if(Array.from(l.sheet.rules).filter((r) => r.href && !r.styleSheet).length)
                    isLoaded = false;
            }
            catch (e) { }
        }
        return !isLoaded;
    });
    if (pendingStyleSheets.length)
        pendingStyleSheets.forEach((l) => { l.addEventListener("load", scrollToTargetCore, { once: true }); });
    else
        scrollToTargetCore();
}