function scrollToAnchor(anchor) {
    var selector = anchor || document.location.hash;
    if (selector && selector.length > 1) {
        var element = document.querySelector(selector);
        if (element) {
            var y = element.getBoundingClientRect().top + window.pageYOffset;
            /*The following code line updates a vertical scroll bar's offset for a standard Blazor Visual Studio template. 
			Update the code to get an offset that is suitable for your application.*/
            y -= document.querySelector(".main .top-row").offsetHeight;
            window.scroll(0, y);
        }
    }
    else
        window.scroll(0, 0);
}