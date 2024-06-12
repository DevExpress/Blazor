var DemoPageSectionHelper = (function() {
    function switchContentPage(id, isCodeVisible) {
        var dNoneSelector = " d-none";
        var sectionSelector = id ? '#section-' + id + ' ' : '';
        var componentAreaEl = document.querySelector(sectionSelector + '.demo-page-section-component-area');
        var codeAreaEl = document.querySelector(sectionSelector + '.demo-page-section-code-area');
        if (!componentAreaEl || !codeAreaEl) return;

        if(isCodeVisible) {
            if(componentAreaEl.offsetHeight > 0) {
                const offset = getCodeAreaOffsetTop();

                codeAreaEl.style.height = "fit-content";
                codeAreaEl.style.maxHeight = `calc(83vh - ${offset}px)`;
            }
            codeAreaEl.className = codeAreaEl.className.replace(dNoneSelector, "");
            if(componentAreaEl.className.indexOf(dNoneSelector) === -1)
                componentAreaEl.className += dNoneSelector;
        }
        else {
            if(codeAreaEl.className.indexOf(dNoneSelector) === -1)
                codeAreaEl.className += dNoneSelector;
            componentAreaEl.className = componentAreaEl.className.replace(dNoneSelector, "");
        }
    }

    function getCodeAreaOffsetTop(element = null) {
        const currentElement = element || document.querySelector('.card-body');
        const parentOffsetTop = currentElement.offsetParent ? getCodeAreaOffsetTop(currentElement.offsetParent) : 0;

        return currentElement.offsetTop + parentOffsetTop;
    }

    function initCopyCodeButtons(id) {
        var sectionSelector = id ? '#section-' + id + ' ' : '';
        var codeAreaEl = document.querySelector(sectionSelector + '.demo-page-section-code-area');
        var copyCodeBtn = codeAreaEl && codeAreaEl.querySelector('.btn.copy-code');
        if(!copyCodeBtn) return;

        new ClipboardJS(copyCodeBtn, {
            text: function () {
                var codeContainerEl = codeAreaEl.querySelector('.code-container');
                var activeCodeIndex = codeContainerEl.dataset["activeIndex"];
                var codeEl = codeAreaEl.querySelector('pre[data-index="' + activeCodeIndex + '"] > code');
                return codeEl && codeEl.textContent;
            }
        });
    }

    function initSwitchTabButtons(id) {
        var sectionSelector = id ? '#section-' + id + ' ' : '';
        var tabButtonsSelector = sectionSelector + '.card .card-header .nav-tabs .nav-item a.nav-link';
        var tabButtons = document.querySelectorAll(tabButtonsSelector);
        var hrefAttr = 'href';

        for(var i = 0; i < tabButtons.length; i++) {
            if (!tabButtons[i].hasAttribute(hrefAttr))
                tabButtons[i].setAttribute(hrefAttr, '#');
        }
    }

    function initExpandCodeButtons(element) {
        var expandBtns = element.querySelectorAll('.more-code-btn');
        for(var i = 0; i < expandBtns.length; i++) {
            (function (btn) { btn.addEventListener("click", function () { expandCode(btn); }) })(expandBtns[i]);
        }
    }
    function expandCode(element) {
        element.parentNode.outerHTML = element.nextSibling.innerHTML;
    }

    return {
        init: function (id, isCodeVisible) {
            switchContentPage(id, isCodeVisible);
            initCopyCodeButtons(id);
            initSwitchTabButtons(id);
        },
        initExpandCodeButtons: initExpandCodeButtons
    };
})();
