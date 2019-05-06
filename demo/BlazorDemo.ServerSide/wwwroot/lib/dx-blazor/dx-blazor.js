var DxBlazor = DxBlazor || {};
DxBlazor.ASPx = DxBlazor.ASPx || {};

(function (DxBlazor) {
    DxBlazor.DxDropDownsInit = function () {
        if (DxBlazor.DxDropDownInitialized) return;
        DxBlazor.DxDropDownInitialized = true;

        document.addEventListener("click", function (evt) {
            if (HasVisibleDropDowns()) {
                window.setTimeout(function () {
                    if (HasVisibleDropDowns()) {
                        DotNet.invokeMethodAsync('DevExpress.Blazor', 'DocumentClick', GetEventPath(evt));
                    }
                }, 100);
            }
        });

        function GetEventPath(evt) {
            var path = [];
            var element = evt.target;
            while (element) {
                path.push({ Id: element.id, Class: element.className, Tag: element.tagName });
                element = element.parentElement;
            }
            return JSON.stringify(path);
        }

        function HasVisibleDropDowns() {
            var dropDowns = document.querySelectorAll(".dxbs-dm");
            var hasVisibleDropDowns = false;
            var ret = dropDowns.forEach(function (node) {
                if (node && node.style.display != "none") {
                    hasVisibleDropDowns = true;
                    return;
                }
            });
            return hasVisibleDropDowns;
        }
    }
})(DxBlazor || (DxBlazor = {}));

(function (DxBlazor, ASPx) {
    // Utils.js 292
    var Browser = {};
    Browser.UserAgent = navigator.userAgent.toLowerCase();
    Browser.Mozilla = false;
    Browser.IE = false;
    Browser.Firefox = false;
    Browser.Netscape = false;
    Browser.Safari = false;
    Browser.Chrome = false;
    Browser.Opera = false;
    Browser.Edge = false;

    Browser.Version = undefined; // {major}.{1-digit minor}
    Browser.MajorVersion = undefined; // {major}

    Browser.WindowsPlatform = false;
    Browser.MacOSPlatform = false;
    Browser.MacOSMobilePlatform = false;
    Browser.AndroidMobilePlatform = false;
    Browser.PlaformMajorVersion = false;
    Browser.WindowsPhonePlatform = false;

    Browser.AndroidDefaultBrowser = false;
    Browser.AndroidChromeBrowser = false;
    Browser.SamsungAndroidDevice = false;
    Browser.WebKitTouchUI = false;
    Browser.MSTouchUI = false;
    Browser.TouchUI = false;

    Browser.WebKitFamily = false; // Safari, Chrome or Opera(Blink)
    Browser.NetscapeFamily = false; // Mozilla, Nestcape, or Firefox
    Browser.HardwareAcceleration = false;
    Browser.VirtualKeyboardSupported = false;
    Browser.Info = "";

    function indentPlatformMajorVersion(userAgent) {
        var regex = /(?:(?:windows nt|macintosh|mac os|cpu os|cpu iphone os|android|windows phone|linux) )(\d+)(?:[-0-9_.])*/;
        var matches = regex.exec(userAgent);
        if (matches)
            Browser.PlaformMajorVersion = matches[1];
    }
    function getIECompatibleVersionString() {
        if (document.compatible) {
            for (var i = 0; i < document.compatible.length; i++)
                if (document.compatible[i].userAgent === "IE" && document.compatible[i].version)
                    return document.compatible[i].version.toLowerCase();
        }
        return "";
    }
    Browser.IdentUserAgent = function (userAgent, ignoreDocumentMode) {
        var browserTypesOrderedList = ["Mozilla", "IE", "Firefox", "Netscape", "Safari", "Chrome", "Opera", "Opera10", "Edge"];
        var defaultBrowserType = "IE";
        var defaultPlatform = "Win";
        var defaultVersions = { Safari: 2, Chrome: 0.1, Mozilla: 1.9, Netscape: 8, Firefox: 2, Opera: 9, IE: 6, Edge: 12 };

        if (!userAgent || userAgent.length == 0) {
            fillUserAgentInfo(browserTypesOrderedList, defaultBrowserType, defaultVersions[defaultBrowserType], defaultPlatform);
            return;
        }

        userAgent = userAgent.toLowerCase();
        indentPlatformMajorVersion(userAgent);
        try {
            var platformIdentStrings = {
                "Windows": "Win",
                "Macintosh": "Mac",
                "Mac OS": "Mac",
                "Mac_PowerPC": "Mac",
                "cpu os": "MacMobile",
                "cpu iphone os": "MacMobile",
                "Android": "Android",
                "!Windows Phone": "WinPhone",
                "!WPDesktop": "WinPhone",
                "!ZuneWP": "WinPhone"
            };

            var optSlashOrSpace = "(?:/|\\s*)?";
            var version = "(\\d+)(?:\\.((?:\\d+?[1-9])|\\d)0*?)?";
            var optVersion = "(?:" + version + ")?";
            var patterns = {
                Safari: "applewebkit(?:.*?(?:version/" + version + "[\\.\\w\\d]*?(?:\\s+mobile\/\\S*)?\\s+safari))?",
                Chrome: "(?:chrome|crios)(?!frame)" + optSlashOrSpace + optVersion,
                Mozilla: "mozilla(?:.*rv:" + optVersion + ".*Gecko)?",
                Netscape: "(?:netscape|navigator)\\d*/?\\s*" + optVersion,
                Firefox: "firefox" + optSlashOrSpace + optVersion,
                Opera: "(?:opera|\sopr)" + optSlashOrSpace + optVersion,
                Opera10: "opera.*\\s*version" + optSlashOrSpace + optVersion,
                IE: "msie\\s*" + optVersion,
                Edge: "edge" + optSlashOrSpace + optVersion
            };

            var browserType;
            var version = -1;
            for (var i = 0; i < browserTypesOrderedList.length; i++) {
                var browserTypeCandidate = browserTypesOrderedList[i];

                var regExp = new RegExp(patterns[browserTypeCandidate], "i");
                if (regExp.compile)
                    regExp.compile(patterns[browserTypeCandidate], "i");
                var matches = regExp.exec(userAgent);

                if (matches && matches.index >= 0) {
                    if (browserType == "IE" && version >= 11 && browserTypeCandidate == "Safari") // WinPhone8.1 update
                        continue;
                    browserType = browserTypeCandidate;
                    if (browserType == "Opera10")
                        browserType = "Opera";
                    var tridentPattern = "trident" + optSlashOrSpace + optVersion;
                    version = Browser.GetBrowserVersion(userAgent, matches, tridentPattern, getIECompatibleVersionString());
                    if (browserType == "Mozilla" && version >= 11)
                        browserType = "IE";
                }
            }

            if (!browserType)
                browserType = defaultBrowserType;
            var browserVersionDetected = version != -1;
            if (!browserVersionDetected)
                version = defaultVersions[browserType];

            var platform;
            var minOccurenceIndex = Number.MAX_VALUE;
            for (var identStr in platformIdentStrings) {
                if (!platformIdentStrings.hasOwnProperty(identStr)) continue;
                var importantIdent = identStr.substr(0, 1) == "!";
                var occurenceIndex = userAgent.indexOf((importantIdent ? identStr.substr(1) : identStr).toLowerCase());
                if (occurenceIndex >= 0 && (occurenceIndex < minOccurenceIndex || importantIdent)) {
                    minOccurenceIndex = importantIdent ? 0 : occurenceIndex;
                    platform = platformIdentStrings[identStr];
                }
            }
            var samsungPattern = "SM-[A-Z]";
            var matches = userAgent.toUpperCase().match(samsungPattern);
            var isSamsungAndroidDevice = matches && matches.length > 0;
            if (platform == "WinPhone" && version < 9)
                version = Math.floor(getVersionFromTrident(userAgent, "trident" + optSlashOrSpace + optVersion));

            if (!ignoreDocumentMode && browserType == "IE" && version > 7 && document.documentMode < version)
                version = document.documentMode;

            if (platform == "WinPhone")
                version = Math.max(9, version);

            if (!platform)
                platform = defaultPlatform;
            if (platform == platformIdentStrings["cpu os"] && !browserVersionDetected) // Terra browser
                version = 4;

            fillUserAgentInfo(browserTypesOrderedList, browserType, version, platform, isSamsungAndroidDevice);
        } catch (e) {
            fillUserAgentInfo(browserTypesOrderedList, defaultBrowserType, defaultVersions[defaultBrowserType], defaultPlatform);
        }
    };
    function getVersionFromMatches(matches) {
        var result = -1;
        var versionStr = "";
        if (matches[1]) {
            versionStr += matches[1];
            if (matches[2])
                versionStr += "." + matches[2];
        }
        if (versionStr != "") {
            result = parseFloat(versionStr);
            if (isNaN(result))
                result = -1;
        }
        return result;
    }
    function getVersionFromTrident(userAgent, tridentPattern) {
        var tridentDiffFromVersion = 4;
        var matches = new RegExp(tridentPattern, "i").exec(userAgent);
        return getVersionFromMatches(matches) + tridentDiffFromVersion;
    }
    Browser.GetBrowserVersion = function (userAgent, matches, tridentPattern, ieCompatibleVersionString) {
        var version = getVersionFromMatches(matches);
        if (ieCompatibleVersionString) {
            var versionFromTrident = getVersionFromTrident(userAgent, tridentPattern);
            if (ieCompatibleVersionString === "edge" || parseInt(ieCompatibleVersionString) === versionFromTrident)
                return versionFromTrident;
        }
        return version;
    };
    function fillUserAgentInfo(browserTypesOrderedList, browserType, version, platform, isSamsungAndroidDevice) {
        for (var i = 0; i < browserTypesOrderedList.length; i++) {
            var type = browserTypesOrderedList[i];
            Browser[type] = type == browserType;
        }
        Browser.Version = Math.floor(10.0 * version) / 10.0;
        Browser.MajorVersion = Math.floor(Browser.Version);
        Browser.WindowsPlatform = platform == "Win" || platform == "WinPhone";
        Browser.MacOSPlatform = platform == "Mac";
        Browser.MacOSMobilePlatform = platform == "MacMobile";
        Browser.AndroidMobilePlatform = platform == "Android";
        Browser.WindowsPhonePlatform = platform == "WinPhone";
        Browser.WebKitFamily = Browser.Safari || Browser.Chrome || Browser.Opera && Browser.MajorVersion >= 15;
        Browser.NetscapeFamily = Browser.Netscape || Browser.Mozilla || Browser.Firefox;
        Browser.HardwareAcceleration = (Browser.IE && Browser.MajorVersion >= 9) || (Browser.Firefox && Browser.MajorVersion >= 4) ||
            (Browser.AndroidMobilePlatform && Browser.Chrome) || (Browser.Chrome && Browser.MajorVersion >= 37) ||
            (Browser.Safari && !Browser.WindowsPlatform) || Browser.Edge || (Browser.Opera && Browser.MajorVersion >= 46);

        Browser.WebKitTouchUI = Browser.MacOSMobilePlatform || Browser.AndroidMobilePlatform;
        var isIETouchUI = Browser.IE && Browser.MajorVersion > 9 && Browser.WindowsPlatform && Browser.UserAgent.toLowerCase().indexOf("touch") >= 0;
        Browser.MSTouchUI = isIETouchUI || (Browser.Edge && !!window.navigator.maxTouchPoints);
        Browser.TouchUI = Browser.WebKitTouchUI || Browser.MSTouchUI;
        Browser.MobileUI = Browser.WebKitTouchUI || Browser.WindowsPhonePlatform;
        Browser.AndroidDefaultBrowser = Browser.AndroidMobilePlatform && !Browser.Chrome;
        Browser.AndroidChromeBrowser = Browser.AndroidMobilePlatform && Browser.Chrome;
        if (isSamsungAndroidDevice)
            Browser.SamsungAndroidDevice = isSamsungAndroidDevice;
        if (Browser.MSTouchUI) {
            var isARMArchitecture = Browser.UserAgent.toLowerCase().indexOf("arm;") > -1;
            Browser.VirtualKeyboardSupported = isARMArchitecture || Browser.WindowsPhonePlatform;
        } else {
            Browser.VirtualKeyboardSupported = Browser.WebKitTouchUI;
        }
        fillDocumentElementBrowserTypeClassNames(browserTypesOrderedList);
    }
    function fillDocumentElementBrowserTypeClassNames(browserTypesOrderedList) {
        var documentElementClassName = "";
        var browserTypeslist = browserTypesOrderedList.concat(["WindowsPlatform", "MacOSPlatform", "MacOSMobilePlatform", "AndroidMobilePlatform",
            "WindowsPhonePlatform", "WebKitFamily", "WebKitTouchUI", "MSTouchUI", "TouchUI", "AndroidDefaultBrowser", "MobileUI"]);
        for (var i = 0; i < browserTypeslist.length; i++) {
            var type = browserTypeslist[i];
            if (Browser[type])
                documentElementClassName += "dx" + type + " ";
        }
        documentElementClassName += "dxBrowserVersion-" + Browser.MajorVersion;
        if (document && document.documentElement) {
            if (document.documentElement.className != "")
                documentElementClassName = " " + documentElementClassName;
            document.documentElement.className += documentElementClassName;
            Browser.Info = documentElementClassName;
        }
    }
    Browser.SupportsStickyPositioning = function () {
        return this.Chrome && this.MajorVersion >= 56
            || this.Firefox && this.MajorVersion >= 32
            || this.Safari && this.MajorVersion >= 6 && this.Version !== "6"
            || this.Opera && this.MajorVersion >= 42;
    };

    // Utils.js 533
    Browser.IdentUserAgent(Browser.UserAgent);
    ASPx.Browser = Browser;

})(DxBlazor, DxBlazor.ASPx);


(function (DxBlazor, ASPx) {
    var Str = {};
    Str.ApplyReplacement = function (text, replecementTable) {
        if (typeof (text) != "string")
            text = text.toString();
        for (var i = 0; i < replecementTable.length; i++) {
            var replacement = replecementTable[i];
            text = text.replace(replacement[0], replacement[1]);
        }
        return text;
    };
    Str.CompleteReplace = function (text, regexp, newSubStr) {
        if (typeof (text) != "string")
            text = text.toString();
        var textPrev;
        do {
            textPrev = text;
            text = text.replace(regexp, newSubStr);
        } while (text != textPrev);
        return text;
    };

    Str.EncodeHtml = function (html) {
        return Str.ApplyReplacement(html, [
            [/&amp;/g, '&ampx;'], [/&/g, '&amp;'],
            [/&quot;/g, '&quotx;'], [/"/g, '&quot;'],
            [/&lt;/g, '&ltx;'], [/</g, '&lt;'],
            [/&gt;/g, '&gtx;'], [/>/g, '&gt;']
        ]);
    };
    Str.DecodeHtml = function (html) {
        return Str.ApplyReplacement(html, [
            [/&gt;/g, '>'], [/&gtx;/g, '&gt;'],
            [/&lt;/g, '<'], [/&ltx;/g, '&lt;'],
            [/&quot;/g, '"'], [/&quotx;/g, '&quot;'],
            [/&amp;/g, '&'], [/&ampx;/g, '&amp;']
        ]);
    };
    Str.DecodeHtmlViaTextArea = function (html) {
        var textArea = document.createElement("TEXTAREA");
        setInnerHtmlInternal(textArea, html);
        return textArea.value;
    };
    Str.TrimStart = function (str) {
        return trimInternal(str, true);
    };
    Str.TrimEnd = function (str) {
        return trimInternal(str, false, true);
    };
    Str.Trim = function (str) {
        return trimInternal(str, true, true);
    };
    Str.EscapeForRegEx = function (str) {
        return str.replace(/[\-\[\]\/\{\}\(\)\*\+\?\.\\\^\$\|]/g, "\\$&");
    };
    var whiteSpaces = {
        0x0009: 1, 0x000a: 1, 0x000b: 1, 0x000c: 1, 0x000d: 1, 0x0020: 1, 0x0085: 1,
        0x00a0: 1, 0x1680: 1, 0x180e: 1, 0x2000: 1, 0x2001: 1, 0x2002: 1, 0x2003: 1,
        0x2004: 1, 0x2005: 1, 0x2006: 1, 0x2007: 1, 0x2008: 1, 0x2009: 1, 0x200a: 1,
        0x200b: 1, 0x2028: 1, 0x2029: 1, 0x202f: 1, 0x205f: 1, 0x3000: 1
    };
    var caretWidth = 1;
    function trimInternal(source, trimStart, trimEnd) {
        var len = source.length;
        if (!len)
            return source;

        if (len < 0xBABA1) { // B181394        
            var result = source;
            if (trimStart) {
                result = result.replace(/^\s+/, "");
            }
            if (trimEnd) {
                result = result.replace(/\s+$/, "");
            }
            return result;
        } else {
            var start = 0;
            if (trimEnd) {
                while (len > 0 && whiteSpaces[source.charCodeAt(len - 1)]) {
                    len--;
                }
            }
            if (trimStart && len > 0) {
                while (start < len && whiteSpaces[source.charCodeAt(start)]) {
                    start++;
                }
            }
            return source.substring(start, len);
        }
    }
    Str.Insert = function (str, subStr, index) {
        var leftText = str.slice(0, index);
        var rightText = str.slice(index);
        return leftText + subStr + rightText;
    };
    Str.InsertEx = function (str, subStr, startIndex, endIndex) {
        var leftText = str.slice(0, startIndex);
        var rightText = str.slice(endIndex);
        return leftText + subStr + rightText;
    };
    var greekSLFSigmaChar = String.fromCharCode(962);
    var greekSLSigmaChar = String.fromCharCode(963);
    Str.PrepareStringForFilter = function (s) {
        s = s.toLowerCase();
        if (ASPx.Browser.WebKitFamily) {
            return s.replace(new RegExp(greekSLFSigmaChar, "g"), greekSLSigmaChar);
        }
        return s;
    };
    Str.GetCoincideCharCount = function (text, filter, textMatchingDelegate) {
        var coincideText = ASPx.Str.PrepareStringForFilter(filter);
        var originText = ASPx.Str.PrepareStringForFilter(text);
        while (coincideText != "" && !textMatchingDelegate(originText, coincideText)) {
            coincideText = coincideText.slice(0, -1);
        }
        return coincideText.length;
    };
    ASPx.Str = Str;

})(DxBlazor, DxBlazor.ASPx);

(function (DxBlazor, ASPx, Str, Browser) {
    // Utils.js 2842
    ASPx.CloneObject = function (srcObject) {
        if (typeof (srcObject) != 'object' || srcObject == null)
            return srcObject;
        var newObject = {};
        /* jshint ignore:start */
        for (var i in srcObject)
            newObject[i] = srcObject[i];
        /* jshint ignore:end */
        return newObject;
    };
    // Utils.js 3057
    ASPx.ElementHasCssClass = function (element, className) {
        //B220674
        try {
            var elementClasses;
            var classList = ASPx.GetClassNameList(element);
            if (!classList) {
                var elementClassName = ASPx.GetClassName(element);
                if (!elementClassName) {
                    return false;
                }
                elementClasses = elementClassName.split(" ");
            }
            var classNames = className.split(" ");
            for (var i = classNames.length - 1; i >= 0; i--) {
                if (classList) {
                    if (classList.indexOf(classNames[i]) === -1)
                        return false;
                    continue;
                }
                if (Data.ArrayIndexOf(elementClasses, classNames[i]) < 0)
                    return false;
            }
            return true;
        } catch (e) {
            return false;
        }
    };
    // Utils.js 3096
    ASPx.AddClassNameToElement = function (element, className) {
        if (!element || typeof (className) !== "string") return;
        className = className.trim();
        if (!ASPx.ElementHasCssClass(element, className) && className !== "") {
            var oldClassName = ASPx.GetClassName(element);
            ASPx.SetClassName(element, (oldClassName === "") ? className : oldClassName + " " + className);
        }
    };
    // Utils.js 3104
    ASPx.RemoveClassNameFromElement = function (element, className) {
        if (!element) return;
        var elementClassName = ASPx.GetClassName(element);
        var updClassName = " " + elementClassName + " ";
        var newClassName = updClassName.replace(" " + className + " ", " ");
        if (updClassName.length != newClassName.length)
            ASPx.SetClassName(element, Str.Trim(newClassName));
    };
    // Utils.js 3128
    ASPx.GetClassNameList = function (element) {
        return element.classList ? [].slice.call(element.classList) : ASPx.GetClassName(element).replace(/^\s+|\s+$/g, '').split(/\s+/);
    };
    // Utils.js 3131
    ASPx.GetClassName = function (element) {
        if (element.tagName === "svg") {
            elementClassName = element.className.baseVal;
        }
        else {
            elementClassName = element.className;
        }
        return elementClassName;
    };
    // Utils.js 3140
    ASPx.SetClassName = function (element, className) {
        if (element.tagName === "svg") {
            element.className.baseVal = Str.Trim(className);
        }
        else {
            element.className = Str.Trim(className);
        }
    };
    // Utils.js 3176
    function getItemByIndex(collection, index) {
        if (!index) index = 0;
        if (collection != null && collection.length > index)
            return collection[index];
        return null;
    }
    // Utils.js 3276
    ASPx.GetNodesByTagName = function (element, tagName) {
        var tagNameToUpper = tagName.toUpperCase();
        var result = null;
        if (element) {
            if (element.getElementsByTagName) {
                result = element.getElementsByTagName(tagNameToUpper);
                if (result.length === 0) {
                    result = element.getElementsByTagName(tagName);
                }
            }
            else if (element.all && element.all.tags !== undefined)
                result = Browser.Netscape ? element.all.tags[tagNameToUpper] : element.all.tags(tagNameToUpper);
        }
        return result;
    };
    // Utils.js 3291
    ASPx.GetNodeByTagName = function (element, tagName, index) {
        if (element != null) {
            var collection = ASPx.GetNodesByTagName(element, tagName);
            return getItemByIndex(collection, index);
        }
        return null;
    };
    // Utils.js 3556
    ASPx.GetCurrentStyle = function (element) {
        if (document.defaultView && document.defaultView.getComputedStyle) {
            var result = document.defaultView.getComputedStyle(element, null);
            if (!result && Browser.Firefox && window.frameElement) {
                var changes = [];
                var curElement = window.frameElement;
                while (!(result = document.defaultView.getComputedStyle(element, null))) {
                    changes.push([curElement, curElement.style.display]);
                    ASPx.SetStylesCore(curElement, "display", "block", true);
                    curElement = curElement.tagName == "BODY" ? curElement.ownerDocument.defaultView.frameElement : curElement.parentNode;
                }
                result = ASPx.CloneObject(result);
                for (var ch, i = 0; ch = changes[i]; i++)
                    ASPx.SetStylesCore(ch[0], "display", ch[1]);
                var dummy = document.body.offsetWidth; //T334387
            }
            if (Browser.Firefox && Browser.MajorVersion >= 62 && window.frameElement && result.length === 0) { //T689462
                result = ASPx.CloneObject(result);
                result.display = element.style.display;
            }
            return result;
        }
        return window.getComputedStyle(element, null);
    };
    // Utils.js 3556
    ASPx.CreateStyleSheetInDocument = function (doc) {
        if (doc.createStyleSheet) {
            try {
                return doc.createStyleSheet();
            }
            catch (e) {
                var message = "The CSS link limit (31) has been exceeded. Please enable CSS merging or reduce the number of CSS files on the page. For details, see http://www.devexpress.com/Support/Center/p/K18487.aspx.";
                throw new Error(message);
            }
        }
        else {
            var styleSheet = doc.createElement("STYLE");
            ASPx.GetNodeByTagName(doc, "HEAD", 0).appendChild(styleSheet);
            return styleSheet.sheet;
        }
    };
    // Utils.js 3597
    ASPx.currentStyleSheet = null;
    ASPx.GetCurrentStyleSheet = function () {
        if (!ASPx.currentStyleSheet)
            ASPx.currentStyleSheet = ASPx.CreateStyleSheetInDocument(document);
        return ASPx.currentStyleSheet;
    };
    // Utils.js 4659
    ASPx.SetStylesCore = function (element, property, value, makeImportant) {
        if (makeImportant) {
            var index = property.search("[A-Z]");
            if (index != -1)
                property = property.replace(property.charAt(index), "-" + property.charAt(index).toLowerCase());
            if (element.style.setProperty)
                element.style.setProperty(property, value, "important");
            else
                element.style.cssText += ";" + property + ":" + value + "!important";
        }
        else
            element.style[property] = value;
    };

})(DxBlazor, DxBlazor.ASPx, DxBlazor.ASPx.Str, DxBlazor.ASPx.Browser);

(function (DxBlazor, ASPx) {
    function getParentByClassNameInternal(element, className, selector) {
        while (element != null) {
            if (element.tagName == "BODY" || element.nodeName == "#document")
                return null;
            if (selector(element, className))
                return element;
            element = element.parentNode;
        }
        return null;
    }
    ASPx.GetParentByClassName = function (element, className) {
        return getParentByClassNameInternal(element, className, ASPx.ElementHasCssClass);
    }
    ASPx.RetrieveByPredicate = function (scourceCollection, predicate) {
        var result = [];
        for (var i = 0; i < scourceCollection.length; i++) {
            var element = scourceCollection[i];
            if (!predicate || predicate(element))
                result.push(element);
        }
        return result;
    };
})(DxBlazor, DxBlazor.ASPx);


(function (DxBlazor, ASPx) {
    var BootstrapCore = {};
    //BootstrapCore.Interactions = new Interactions();
    BootstrapCore.BootstrapMode = "Bootstrap4";
    BootstrapCore.IsBootstrap3 = BootstrapCore.BootstrapMode == "Bootstrap3";
    BootstrapCore.IsBootstrap4 = BootstrapCore.BootstrapMode == "Bootstrap4";
    //BootstrapCore.CheckReferences = '<%=WebResource("custom:CheckReferences")%>';

    BootstrapCore.zIndexCategories = {
        dropdown: 1000,
        sticky: 1020,
        fixed: 1030,
        modalBackdrop: 1040,
        modal: 1050,
        popover: 1060,
        tooltip: 1070
    };

    var BootstrapCssSelectors = {};
    BootstrapCssSelectors.Table = "table";
    BootstrapCssSelectors.TableBordered = "table-bordered";
    BootstrapCssSelectors.TableSmall = BootstrapCore.IsBootstrap3 ? "table-condensed" : "table-sm";
    BootstrapCssSelectors.TableActive = BootstrapCore.IsBootstrap3 ? "" : "table-active";
    BootstrapCssSelectors.BackgroundLight = BootstrapCore.IsBootstrap3 ? "" : "bg-light";
    BootstrapCssSelectors.BackgroundPrimary = BootstrapCore.IsBootstrap3 ? "bg-primary" : "bg-primary text-white";
    BootstrapCssSelectors.BackgroundDanger = "bg-danger";
    BootstrapCssSelectors.Hidden = BootstrapCore.IsBootstrap3 ? "hidden" : "d-none";

    BootstrapCssSelectors.Row = "row";
    BootstrapCssSelectors.Column = "col";
    BootstrapCssSelectors.ColumnAuto = BootstrapCore.IsBootstrap3 ? "" : "col-auto";

    BootstrapCssSelectors.Panel = BootstrapCore.IsBootstrap3 ? "panel" : "card";
    BootstrapCssSelectors.PanelDefault = BootstrapCore.IsBootstrap3 ? "panel-default" : "";
    BootstrapCssSelectors.PanelHeading = BootstrapCore.IsBootstrap3 ? "panel-heading" : "card-header";
    BootstrapCssSelectors.PanelTitle = BootstrapCore.IsBootstrap3 ? "panel-title" : "card-title";
    BootstrapCssSelectors.PanelBody = BootstrapCore.IsBootstrap3 ? "panel-body" : "card-body";
    BootstrapCssSelectors.PanelFooter = BootstrapCore.IsBootstrap3 ? "panel-footer" : "card-footer";

    BootstrapCssSelectors.Radio = BootstrapCore.IsBootstrap3 ? "radio" : "form-check";
    BootstrapCssSelectors.CheckBox = BootstrapCore.IsBootstrap3 ? "checkbox" : "form-check";
    BootstrapCssSelectors.InlineCheckBox = BootstrapCore.IsBootstrap3 ? "checkbox-inline" : "form-check form-check-inline";
    BootstrapCssSelectors.CheckBoxLabel = BootstrapCore.IsBootstrap3 ? "" : "form-check-label";
    BootstrapCssSelectors.CheckBoxInput = BootstrapCore.IsBootstrap3 ? "" : "form-check-input";
    BootstrapCssSelectors.ControlLabel = BootstrapCore.IsBootstrap3 ? "control-label" : "col-form-label";
    BootstrapCssSelectors.FormControlStatic = BootstrapCore.IsBootstrap3 ? "form-control-static" : "form-control-plaintext";
    BootstrapCssSelectors.HelpBlock = BootstrapCore.IsBootstrap3 ? "help-block" : "form-text";
    BootstrapCssSelectors.HasError = BootstrapCore.IsBootstrap3 ? "has-error" : "";
    BootstrapCssSelectors.FormControlFeedback = BootstrapCore.IsBootstrap3 ? "form-control-feedback" : "dxbs-feedback";
    BootstrapCssSelectors.InvalidFormControl = BootstrapCore.IsBootstrap3 ? "" : "is-invalid";
    BootstrapCssSelectors.InvalidFeedback = BootstrapCore.IsBootstrap3 ? "" : "invalid-feedback";
    BootstrapCssSelectors.InputGroup = "input-group";
    BootstrapCssSelectors.InputGroupAppendButton = BootstrapCore.IsBootstrap3 ? "input-group-btn" : "input-group-append";
    BootstrapCssSelectors.InputGroupPrependButton = BootstrapCore.IsBootstrap3 ? "input-group-btn" : "input-group-prepend";

    BootstrapCssSelectors.Divider = BootstrapCore.IsBootstrap3 ? "divider" : "dropdown-divider";
    BootstrapCssSelectors.NavItem = BootstrapCore.IsBootstrap3 ? "" : "nav-item";
    BootstrapCssSelectors.NavLink = BootstrapCore.IsBootstrap3 ? "" : "nav-link";
    BootstrapCssSelectors.DropDownMenu = "dropdown-menu";
    BootstrapCssSelectors.DropDownMenuItem = BootstrapCore.IsBootstrap3 ? "" : "dropdown-item";
    BootstrapCssSelectors.ListBoxItemLink = BootstrapCore.IsBootstrap3 ? "list-group-item" : "list-group-item list-group-item-action";

    BootstrapCssSelectors.Breabcrumb = "breadcrumb";
    BootstrapCssSelectors.BreadcrumbItem = BootstrapCore.IsBootstrap3 ? "" : "breadcrumb-item";

    BootstrapCssSelectors.Toolbar = "btn-toolbar";
    BootstrapCssSelectors.Button = "btn";
    BootstrapCssSelectors.ButtonGroup = "btn-group";
    BootstrapCssSelectors.ButtonGroupVertical = "btn-group-vertical";
    BootstrapCssSelectors.DropDown = "dropdown";
    BootstrapCssSelectors.DropDownToggle = "dropdown-toggle";

    BootstrapCssSelectors.Modal = "modal";
    BootstrapCssSelectors.ModalContent = "modal-content";
    BootstrapCssSelectors.ModalBody = "modal-body";
    BootstrapCssSelectors.ModalHeader = "modal-header";
    BootstrapCssSelectors.ModalTitle = "modal-title";
    BootstrapCssSelectors.ModalFooter = "modal-footer";
    BootstrapCssSelectors.ModalBackdrop = "modal-backdrop " + (BootstrapCore.IsBootstrap3 ? "in" : "show");

    BootstrapCssSelectors.Label = BootstrapCore.IsBootstrap3 ? "label" : "badge";
    BootstrapCssSelectors.TextCenter = "text-center";

    BootstrapCssSelectors.Alert = "alert";

    function selectClass() { return arguments[+(arguments.length > 1 && !BootstrapCore.IsBootstrap3)]; }

    BootstrapCssSelectors.Popover = selectClass("popover");
    BootstrapCssSelectors.PopoverArrow = selectClass("arrow");
    BootstrapCssSelectors.PopoverBody = selectClass("popover-content", "popover-body");
    BootstrapCssSelectors.PopoverHeader = selectClass("popover-title", "popover-header");
    BootstrapCssSelectors.PopoverBottom = selectClass("bottom", "bs-popover-bottom");
    BootstrapCssSelectors.PopoverLeft = selectClass("left", "bs-popover-left");
    BootstrapCssSelectors.PopoverRight = selectClass("right", "bs-popover-right");
    BootstrapCssSelectors.PopoverTop = selectClass("top", "bs-popover-top");
    BootstrapCssSelectors.Tooltip = selectClass("tooltip");
    BootstrapCssSelectors.TooltipArrow = selectClass("tooltip-arrow", "arrow");
    BootstrapCssSelectors.TooltipContent = selectClass("tooltip-inner");
    BootstrapCssSelectors.TooltipBottom = selectClass("bottom", "bs-tooltip-bottom");
    BootstrapCssSelectors.TooltipLeft = selectClass("left", "bs-tooltip-left");
    BootstrapCssSelectors.TooltipRigth = selectClass("right", "bs-tooltip-right");
    BootstrapCssSelectors.TooltipTop = selectClass("top", "bs-tooltip-top");
    BootstrapCssSelectors.Border = selectClass("dxbs-border", "border");
    BootstrapCssSelectors.TableHeadLight = selectClass("", "thead-light");
    BootstrapCssSelectors.TextRight = selectClass("text-right");
    BootstrapCssSelectors.PanelHeadingTabs = selectClass("panel-heading-tabs", "card-header-tabs");

    var mediaQueryScreenSizesCache = {};
    function createCssRuleForScreenSizeMediaQuery(cssVarName, fallbackWidth, cssRule) {
        var cache = mediaQueryScreenSizesCache;
        var minWidth = cache[cssVarName] || (cache[cssVarName] = (ASPx.GetCurrentStyle(document.body).getPropertyValue(cssVarName) || fallbackWidth));
        if (minWidth) {
            var styleSheet = ASPx.GetCurrentStyleSheet();
            if (styleSheet)
                styleSheet.insertRule("@media (min-width: " + minWidth + ") {\n" + cssRule + "\n}\n", styleSheet.cssRules.length);
        }
    }
    BootstrapCore.createCssRuleForLargeScreen = function (cssRule) {
        createCssRuleForScreenSizeMediaQuery("--breakpoint-lg", "992px", cssRule);
    };

    ASPx.BootstrapCore = BootstrapCore;
    ASPx.BootstrapCssSelectors = BootstrapCssSelectors;
})(DxBlazor, DxBlazor.ASPx);

(function (DxBlazor, ASPx) {
    var FL_CLASS = "dxbs-fl",
        CALC_CLASS = "dxbs-fl-calc",
        FLI_CLASS = "form-group",
        FLIC_CLASS = "dxbs-fl-cpt",
        FLGB_CLASS = ASPx.BootstrapCssSelectors.Panel,
        FLGBC_CLASS = ASPx.BootstrapCssSelectors.PanelHeading;

    var patternRegex = /\./g;
    function encodeDotsForMediaQuiery(value) {
        return value.replace(patternRegex, "\\$&");
    }
    DxBlazor.DxFormLayoutInit = function (id) {
        var alignItemCaptionsInAllGroups = true;
        createAdaptivityCssRules(id);

        //function recreateAdaptivityCssRules() {
        //    this.adaptivityRulesCreated = false;
        //    this.createAdaptivityCssRules();
        //}
        function GetMainElement() { return document.getElementById(id); }
        function createAdaptivityCssRules(id) {
            //    if (this.adaptivityRulesCreated) return;

            var width = 0;
            var mainElement = GetMainElement();
            ASPx.AddClassNameToElement(mainElement, CALC_CLASS);

            if (alignItemCaptionsInAllGroups) {
                width = getMaxCaptionWidth(mainElement, true);
                createAdaptivityCssRulesForElements(GetMainElement(), width);
            }
            else {
                var groupElements = getGroupElements(mainElement);
                width = getMaxCaptionWidth(mainElement, false);
                createAdaptivityCssRulesForElements(mainElement, width);
                for (var i = 0; i < groupElements.length; i++) {
                    width = getMaxCaptionWidth(groupElements[i], false);
                    createAdaptivityCssRulesForElements(groupElements[i], width);
                }
            }
            ASPx.RemoveClassNameFromElement(mainElement, CALC_CLASS);
            //if (width > 0)
            //    this.adaptivityRulesCreated = true;
        }
        function getGroupElements(container) {
            return getFilteredElements(container.querySelectorAll(".dxbs-fl-g, .dxbs-fl-gd, .dxbs-fl-gt"));
        }
        function getFilteredElements(elements) {
            var mainElement = GetMainElement();
            return ASPx.RetrieveByPredicate(elements, function (el) { return ASPx.GetParentByClassName(el, FL_CLASS) == mainElement; });
        }
        function getMaxCaptionWidth(container, recursive) {
            var width = 0;
            var elements = getCaptionElements(container, recursive);
            for (var i = 0; i < elements.length; i++) {
                var captionWidth = elements[i].offsetWidth;
                if (captionWidth > width && captionWidth < elements[i].parentNode.offsetWidth)
                    width = captionWidth;
            }
            return width > 0 ? (width + (ASPx.Browser.HardwareAcceleration ? 1 : 0)) : 0;
        }
        function getAdaptivityCssRulesPrefix(container) {
            var mainElement = GetMainElement();
            var prefix = "#" + encodeDotsForMediaQuiery(id) + ".dxbs-fl.form-horizontal ";
            if (container != mainElement)
                prefix += "#" + encodeDotsForMediaQuiery(container.id) + " ";

            var flElement = mainElement;
            while (true) {
                flElement = ASPx.GetParentByClassName(flElement.parentNode, FL_CLASS);
                if (flElement)
                    prefix = "#" + encodeDotsForMediaQuiery(flElement.id) + " " + prefix;
                else
                    break;
            }
            return prefix;
        }
        function createAdaptivityCssRulesForElements(container, width) {
            if (width === 0) return;

            if (!container.itemCaptionWidth || width > container.itemCaptionWidth) {
                container.itemCaptionWidth = width;

                var mediaRulePrefix = getAdaptivityCssRulesPrefix(container);
                mediaRule = mediaRulePrefix + ".form-group > .dxbs-fl-cpt {\n width:" + width + "px;\n}\n";

                mediaRule += mediaRulePrefix + ".form-group > .dxbs-fl-ctrl:not(img):not(.dxbs-fl-ctrl-nc) {\n width: calc(100% - " + width + "px);\n}\n";
                mediaRule += mediaRulePrefix + ".form-group > .dxbs-textbox:not(img):not(.dxbs-fl-ctrl-nc) {\n width: calc(100% - " + width + "px);\n}\n";
                mediaRule += mediaRulePrefix + ".form-group > .dxbs-dropdown-edit:not(img):not(.dxbs-fl-ctrl-nc) {\n width: calc(100% - " + width + "px);\n}\n";
                mediaRule += mediaRulePrefix + ".form-group > .dxbs-spin-edit:not(img):not(.dxbs-fl-ctrl-nc) {\n width: calc(100% - " + width + "px);\n}\n";

                mediaRule += mediaRulePrefix + ".row > div > ." + ASPx.BootstrapCssSelectors.HelpBlock + " {\n margin-left: " + width + "px;\n}\n";
                ASPx.BootstrapCore.createCssRuleForLargeScreen(mediaRule);
            }
        }
        function getCaptionElements(container, recursive) {
            if (recursive)
                return getFilteredElements(container.querySelectorAll(".dxbs-fl-cpt." + ASPx.BootstrapCssSelectors.ControlLabel));
            return container.querySelectorAll("#" + container.id + " > .row > div:not(.dxbs-fl-g):not(.dxbs-fl-gd):not(.dxbs-fl-gt) > .form-group > ." + ASPx.BootstrapCssSelectors.ControlLabel + ", " +
                "#" + container.id + ".dxbs-fl-gd > ." + ASPx.BootstrapCssSelectors.Panel + " > .row > div:not(.dxbs-fl-g):not(.dxbs-fl-gd):not(.dxbs-fl-gt) > .form-group > ." + ASPx.BootstrapCssSelectors.ControlLabel + ", " +
                "#" + container.id + ".dxbs-fl-gt > .dxbs-tabs > .tab-content > .tab-pane > .row > div:not(.dxbs-fl-g):not(.dxbs-fl-gd):not(.dxbs-fl-gt) > .form-group > ." + ASPx.BootstrapCssSelectors.ControlLabel);
        }
    }
})(DxBlazor, DxBlazor.ASPx);