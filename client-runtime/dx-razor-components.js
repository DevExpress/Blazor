window["DxControlsInit"] = function () {
	if (window.DxControlsInitialized) return;
	window.DxControlsInitialized = true;

	document.addEventListener("click", function (evt) {
		window.setTimeout(function () {
            DotNet.invokeMethodAsync('DevExpress.RazorComponents', 'DocumentClick', GetEventPath(evt));
		}, 0);
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
}