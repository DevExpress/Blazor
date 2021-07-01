using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Components;
using BlazorDemo.Configuration;
using Microsoft.Extensions.Configuration;

namespace BlazorDemo.AspNetCoreHost {
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public partial class UploadController : ControllerBase {
        protected string ContentRootPath { get; set; }
        /*BeginHide*/
        protected bool SiteMode { get; set; }
        /*EndHide*/

        public UploadController(IWebHostEnvironment hostingEnvironment/*BeginHide*/, DemoConfiguration configuration/*EndHide*/) {
            ContentRootPath = hostingEnvironment.ContentRootPath;
            /*BeginHide*/
            SiteMode = configuration.GetConfigurationValue<bool>("SiteMode");
            /*EndHide*/
        }
        public string GetOrCreateUploadFolder() {
            var path = Path.Combine(ContentRootPath, "uploads");
            if(!Directory.Exists(path))
                Directory.CreateDirectory(path);
            /*BeginHide*/
            else
                CleanOutdatedFiles(path, new TimeSpan(0, 5, 0));
            /*EndHide*/
            return path;
        }
        /*BeginHide*/
        protected void CleanOutdatedFiles(string path, TimeSpan delay) {
            if(!SiteMode)
                return;
            var dir = new DirectoryInfo(path);
            if(dir.Exists) {
                foreach(var file in dir.GetFiles().Where(f => f.LastWriteTimeUtc.Add(delay) < DateTime.UtcNow)) {
                    file.Delete();
                }
            }
        }
        /*EndHide*/
    }
}
