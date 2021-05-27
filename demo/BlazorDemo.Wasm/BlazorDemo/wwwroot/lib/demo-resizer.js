var target;
var startWidth;
var maxWidth;

function initResizeHandler(targetId) {
    const resizeHandlers = document.getElementsByClassName("demo-resize-handler");
    if(resizeHandlers.length > 0) {
        target = document.getElementById(targetId);
        resizeHandlers[0].addEventListener('touchstart', (e) => {
            startWidth = target.offsetWidth - e.touches[0].clientX;
            if(!maxWidth)
                maxWidth = target.offsetWidth;
            window.addEventListener('selectstart', disableSelect);
            window.addEventListener('touchmove', touchResizing);
            window.addEventListener('touchend', stopTouch);
        }, { passive: true });

        resizeHandlers[0].addEventListener('mousedown', (e) => {
            startWidth = target.offsetWidth - e.clientX;
            if(!maxWidth)
                maxWidth = target.offsetWidth;
            window.addEventListener('selectstart', disableSelect);
            window.addEventListener('mousemove', resizing);
            window.addEventListener('mouseup', stopResizing);
        });
        window.addEventListener("resize", () => { target.style.width = null; maxWidth = null; });
    }
}
function resizing(e) {
    target.style.width = Math.min(maxWidth, startWidth + e.clientX) + 'px';
}
function touchResizing(e) {
    target.style.width = Math.min(maxWidth, startWidth + e.touches[0].clientX) + 'px';
}
function stopResizing() {
    window.removeEventListener('selectstart', disableSelect);
    window.removeEventListener('mousemove', resizing);
    window.removeEventListener('mouseup', stopResizing);
}
function stopTouch() {
    window.removeEventListener('selectstart', disableSelect);
    window.removeEventListener('touchmove', touchResizing);
    window.removeEventListener('touchend', stopTouch);
}
function disableSelect(e) {
    e.preventDefault();
}
