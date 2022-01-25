window["ReportDesignerExit"] = function() {
    history.back();
}
window["_dxr_setId"] = function(key, id) {
    var date = new Date();
    date.setMonth(date.getMonth() + 1);
    window["_dx_demoPageHelper"].setCookie(key, id, date);
}
