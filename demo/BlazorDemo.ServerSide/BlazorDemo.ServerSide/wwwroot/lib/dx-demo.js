hljs.initHighlightingOnLoad();
function HighlightJSUpdate() {
    document.querySelectorAll('pre code').forEach((block) => {
        hljs.highlightBlock(block);
    });
}
function UpdateSharingButton() {
    window.setTimeout(function () {
        try {
            twttr.widgets.load();
            FB.XFBML.parse();
        } catch (e) {
            return null;
        }
    }, 0);
}