hljs.initHighlightingOnLoad();
function HighlightJSUpdate() {
    document.querySelectorAll('pre code').forEach((block) => {
        hljs.highlightBlock(block);
    });
}
function UpdateSharingButton() {
    window.setTimeout(function () {
        try {
            var container = document.querySelector(".social-panel")
            twttr.widgets.load(container);
            FB.XFBML.parse(container);
        } catch (e) {
            return null;
        }
    }, 0);
}