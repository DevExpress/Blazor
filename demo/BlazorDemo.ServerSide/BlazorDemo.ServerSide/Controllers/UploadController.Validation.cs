using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.AspNetCoreHost {
    public partial class UploadController : ControllerBase {
        [HttpPost("[action]")]
        public ActionResult UploadImage(IFormFile myFile) {
            /*BeginHide*/
            if(!Configuration.SiteMode) {
            /*EndHide*/
            try {
                string[] imageExtensions = { ".jpg", ".jpeg", ".gif", ".png" };

                var fileName = myFile.FileName.ToLower();
                var isValidExtenstion = imageExtensions.Any(ext => {
                    return fileName.LastIndexOf(ext) > -1;
                });

                if(isValidExtenstion) {
                    var path = Path.Combine(HostingEnvironment.ContentRootPath, "uploads");
                    if(!Directory.Exists(path))
                        Directory.CreateDirectory(path);

                    using(var fileStream = System.IO.File.Create(Path.Combine(path, myFile.FileName))) {
                        myFile.CopyTo(fileStream);
                    }
                }
            } catch {
                Response.StatusCode = 400;
            }
            /*BeginHide*/
            }
            /*EndHide*/
            return new EmptyResult();
        }
    }
}
