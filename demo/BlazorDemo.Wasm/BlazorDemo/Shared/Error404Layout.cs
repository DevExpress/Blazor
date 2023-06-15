using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorDemo.Configuration;
using DevExpress.XtraPrinting.Native;
using Microsoft.AspNetCore.Components;
#if SERVER_BLAZOR
using Microsoft.AspNetCore.Http;
#endif

namespace BlazorDemo.Shared {
    public class Error404Layout : MainLayout {
#if SERVER_BLAZOR
        [Inject] IHttpContextAccessor HttpContextAccessor { get; set; }
        [Inject] DemoConfiguration Configuration { get; set; }
        protected override void OnInitialized() {
            if(!HttpContextAccessor.HttpContext.Response.HasStarted) {
                if(!TryPermanentRedirect(NavigationManager.Uri))
                    HttpContextAccessor.HttpContext.Response.StatusCode = 404;
            }
            base.OnInitialized();
        }
        protected bool TryPermanentRedirect(string url) {
            if(Configuration.IsServerSide && TryGetRedirectUrl(url, out var uri)) {
                var newUri = new Uri(new Uri(NavigationManager.BaseUri), uri);
                HttpContextAccessor.HttpContext.Response.Redirect(newUri.ToString(), true);
                return true;
            };
            return false;
        }
#endif
    }
}
