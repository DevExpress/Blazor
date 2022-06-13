var DemoPageSectionHelper = (function() {
    function switchContentPage(id, isCodeVisible) {
        var dNoneSelector = " d-none";
        var sectionSelector = id ? '#section-' + id + ' ' : '';
        var componentAreaEl = document.querySelector(sectionSelector + '.demo-page-section-component-area');
        var codeAreaEl = document.querySelector(sectionSelector + '.demo-page-section-code-area');
        if (!componentAreaEl || !codeAreaEl) return;
        
        if(isCodeVisible) {
            if(componentAreaEl.offsetHeight > 0)
                codeAreaEl.style.height = componentAreaEl.offsetHeight + "px";
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
        },
        initExpandCodeButtons: initExpandCodeButtons
    };
})();
