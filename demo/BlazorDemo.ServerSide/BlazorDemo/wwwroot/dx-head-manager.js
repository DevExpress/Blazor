function _dxInitDocumentEnvironment(_dotnetRef) {
    return new Promise(function (resolve) {
        resolve();
    })
}
function _bulkUpdateMetadata(_dotnetRef, data) {
    return new Promise(function (resolve) {
        data.forEach(applyDataItem);
        resolve();
    });

    function applyDataItem(dataItem) {
        if(dataItem.flag === 640)
            applyStyleSheet(dataItem.name, dataItem.value);
        else if (dataItem.flag === 288)
            document.title = dataItem.value;
    }

    function applyStyleSheet(name, src) {
        if(name) {
            var stylesheet = document.getElementById(name);
            var uri = encodeURI(src);
            if(!stylesheet.href.endsWith(uri)) {
                stylesheet.href = uri;
                setTimeout(() => updateAccentColorStyle(), 500);
            }
        }
    }
    function updateAccentColorStyle() {
        if(window.dxAccentColorStyle)
            window.dxAccentColorStyle.update();
    }
}
