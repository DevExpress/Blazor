using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorDemo.Services {
    public static class ReportingCookieHelper {
        public static string IdCookieKey => "xrId";
        public static async Task<string> SetSessionID(IJSRuntime jsRuntime) {
            var xrId = await jsRuntime.InvokeAsync<string>("_dx_demoPageHelper.getCookie", IdCookieKey);
            if(string.IsNullOrEmpty(xrId)) {
                xrId = Guid.NewGuid().ToString("N");
                await jsRuntime.InvokeAsync<string>("_dxr_setId", IdCookieKey, xrId);
            }
            return xrId;
        }
    }
}
