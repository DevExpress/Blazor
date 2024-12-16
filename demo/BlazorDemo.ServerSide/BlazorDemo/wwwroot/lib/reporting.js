window["ReportDesignerExit"] = function() {
    history.back();
}
window["_dxr_setId"] = function(key, id) {
    var date = new Date();
    date.setMonth(date.getMonth() + 1);
    window["_dx_demoPageHelper"].setCookie(key, id, date);
}

window["_dxr_onViewerInitializing"] = function (s, e) {
    var currentURL = window.location.href;
    if (currentURL.includes("AIPoweredExtensions")) {
        DevExpress.Reporting.Viewer.Settings.AILanguages([{ key: 'en', text: 'English' }, { key: 'de', text: 'German' }]);
        DevExpress.Reporting.Viewer.Settings.AIServicesEnabled(true);
    } else {
        DevExpress.Reporting.Viewer.Settings.AILanguages([]);
        DevExpress.Reporting.Viewer.Settings.AIServicesEnabled(false);
    }
}
