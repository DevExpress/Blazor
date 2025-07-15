window["ReportDesignerExit"] = function() {
    history.back();
}
window["_dxr_setId"] = function(key, id) {
    var date = new Date();
    date.setMonth(date.getMonth() + 1);
    window["_dx_demoPageHelper"].setCookie(key, id, date);
}

window["_dxr_onViewerBeforeRender"] = function (s, e) {
    var currentURL = window.location.href;
    if (currentURL.includes("AIPoweredExtensions")) {
        DevExpress.Reporting.Viewer.Settings.AIServicesEnabled(true);        
    } else {
        DevExpress.Reporting.Viewer.Settings.AIServicesEnabled(false);        
    }
}

window["_dxr_DesignerUpdateAIServices"] = function (s, e) {
    var currentURL = window.location.href;
    if (currentURL.includes("AIPoweredExtensions")) {
        DevExpress.Reporting.Viewer.Settings.AIServicesEnabled(true);
        DevExpress.Reporting.Designer.Settings.AIServicesEnabled(true);
    } else {
        DevExpress.Reporting.Viewer.Settings.AIServicesEnabled(false);
        DevExpress.Reporting.Designer.Settings.AIServicesEnabled(false);
    }
}
