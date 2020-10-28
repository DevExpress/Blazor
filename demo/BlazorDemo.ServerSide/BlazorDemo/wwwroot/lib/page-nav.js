var DemoPageNavPanel = (function() {
    function addDemoAnchorIntersectionObserver() {
		var scrollableContainer = document.querySelector('.main');
	
		var options = {
			root: scrollableContainer,
			rootMargin: '0px 0px -80% 0px',
			threshold: [0, 1]
		};
		var observer = new IntersectionObserver(demoAnchorIntersectionHandler, options);
		var demoAnchorLinks = document.querySelectorAll('.demo-anchor');
		demoAnchorLinks.forEach(link => observer.observe(link));

		var footerObserverOptions = {
			root: scrollableContainer,
			threshold: [0, 1]
		};
		var footerObserver = new IntersectionObserver(demoFooterIntersectionHandler, footerObserverOptions);
		var footerElement = document.querySelector('.main > .footer');
		footerObserver.observe(footerElement);
	}

	function demoAnchorIntersectionHandler(entries) {
		entries.forEach(entry => {
			var demoAnchorLinkUrl = entry.target.href;
			var demoNavPanelItems = Array.from(document.querySelectorAll('.demo-page-nav .nav-pills .nav-link'));
			var demoNavTargetItem = document.querySelector('.nav-target');
			if(entry.isIntersecting) {
				demoNavPanelItems.forEach(item => {
					if(item.href === demoAnchorLinkUrl) {
						if(!demoNavTargetItem || item.classList.contains('nav-target'))
							setDemoNavPanelItemActive(item, true);
					}
					else
						setDemoNavPanelItemActive(item, false);
				});
			}
			else {
				var targetElementBottom = entry.boundingClientRect.bottom;
				if(targetElementBottom >= entry.rootBounds.bottom && targetElementBottom <= document.documentElement.clientHeight) {
					var demoNavPanelItem = demoNavPanelItems.filter(item => item.href === demoAnchorLinkUrl)[0];
					var prevIndex = demoNavPanelItems.indexOf(demoNavPanelItem) - 1;
					if(prevIndex > -1) {
						setDemoNavPanelItemActive(demoNavPanelItem, false);
						if(!demoNavTargetItem || demoNavPanelItems[prevIndex].classList.contains('nav-target')) {
							demoNavPanelItems.forEach(item => { setDemoNavPanelItemActive(item, false); });
							setDemoNavPanelItemActive(demoNavPanelItems[prevIndex], true);
						}
					}
				}
			}
		});
	}

	function demoFooterIntersectionHandler(entries) {
		entries.forEach(entry => {
			if(entry.isIntersecting) {
				var demoNavPanelItems = Array.from(document.querySelectorAll('.demo-page-nav .nav-pills .nav-link'));
				demoNavPanelItems.forEach((item, index) => {
					setDemoNavPanelItemActive(item, index == demoNavPanelItems.length - 1);
				});
			}
		});
	}

	function setDemoNavPanelItemActive(itemElement, isActive) {
		if(isActive) {
			itemElement.classList.add('active');
			if(itemElement.classList.contains('nav-target'))
				itemElement.classList.remove('nav-target');
			var headerTextElement = document.querySelector('.demo-page-nav .nav-header-text');
			headerTextElement.innerText = itemElement.querySelector(".text").innerText;
		}
		else {
			if(itemElement.classList.contains('active'))
				itemElement.classList.remove('active');
		}
    }

    return {
        addDemoAnchorIntersectionObserver: addDemoAnchorIntersectionObserver
    };
})();
