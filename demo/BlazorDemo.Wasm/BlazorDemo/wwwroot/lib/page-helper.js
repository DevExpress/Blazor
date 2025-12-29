var DemoPageHelper = (function() {
    function scrollToElementTop(element) {
        if(element.scroll)
            element.scroll(0, 0);
        else {
            element.scrollTop = 0;
            element.scrollLeft = 0;
        }
    }
    function ensureNavigationTargetIsVisible() {
        var targetSelector = document.location.hash;
        if(targetSelector) {
            var demoAnchorLinks = Array.from(document.querySelectorAll('.demo-anchor'));
            var targetElement = demoAnchorLinks.filter(function(l) { return l.href.toLowerCase() === document.location.href.toLowerCase() && l.href.endsWith(targetSelector); })[0];
            if(targetElement)
                targetElement.scrollIntoView();
        }
    }

    function getCookie(name) {
        name = escape(name);
        var cookies = document.cookie.split(';');
        for(var i = 0; i < cookies.length; i++) {
            var cookie = cookies[i].trim();
            if(cookie.indexOf(name + '=') == 0)
                return unescape(cookie.substring(name.length + 1, cookie.length));
            else if(cookie.indexOf(name + ';') == 0 || cookie === name)
                return '';
        }
        return null;
    }
    function setCookie(name, value, date, sameSite) {
        document.cookie = escape(name) + '=' + escape(value.toString()) + '; expires=' + date.toGMTString() + '; path=/' + resolveCookieSameSite(sameSite);
    }
	function resolveCookieSameSite(sameSite) { // https://developer.mozilla.org/en-US/docs/Web/HTTP/Guides/Cookies#controlling_third-party_cookies_with_samesite
		var cookieSameSitePossibleValues = ["none", "lax", "strict"];
		var index = -1;
		if(sameSite)
			index = cookieSameSitePossibleValues.indexOf(sameSite.toString().toLowerCase());
		if(index < 0)
			index = 1; // Lax by default
		sameSite = cookieSameSitePossibleValues[index];

		var result = "; SameSite=" + sameSite;
		if(sameSite === "none") // if SameSite=None is set then the Secure attribute must also be set
			result += "; Secure";
		return result;
	}

    function setTheme(cookieName, themeName, themeOptions) {
        var date = new Date();
        date.setFullYear(date.getFullYear() + 1);
        setCookie(cookieName, themeName, date);
        setCookie(`${cookieName}_Opts`, themeOptions, date);
    }

    function demoMatchesQuery(mediaQuery, dotNetHelper) {
        var query = window.matchMedia(mediaQuery), pendingCall;
        handleQuery(query).then(function() {
            return query.addListener(handleQuery);
        });

        function handleQuery(queryMatch) {
            return (pendingCall || Promise.resolve(true))
                .then(function() {
                    return pendingCall = new Promise(function(resolve, reject) {
                        dotNetHelper.invokeMethodAsync('OnQueryChanged', queryMatch.matches).then(resolve).catch(reject);
                    });
                });
        }
    }

    function patchAppElement() {
        var appEl = document.getElementById("app");
        if(appEl) appEl.className = "root";
    }

    function raiseWindowOnResize() {
        window.setTimeout(function() {
            var event = window.document.createEvent('UIEvents');
            event.initUIEvent('resize', true, false, window, 0);
            window.dispatchEvent(event);
        }, 100);
    }

    return {
        scroll: {
            toElementTop: scrollToElementTop,
            ensureNavigationTargetIsVisible: ensureNavigationTargetIsVisible
        },
        themes: {
            setTheme
        },
        getCookie: getCookie,
        setCookie: setCookie,
        demoMatchesQuery: demoMatchesQuery,
        patchAppElement: patchAppElement,
        raiseWindowOnResize: raiseWindowOnResize
    };
})();

window["_dx_demoPageHelper"] = DemoPageHelper;
