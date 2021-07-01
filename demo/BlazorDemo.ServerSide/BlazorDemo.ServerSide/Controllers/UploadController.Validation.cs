using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.AspNetCoreHost {
    public partial class UploadController : ControllerBase {
        [HttpPost("[action]")]
        public ActionResult UploadImage(IFormFile myFile) {
            try {
                string[] imageExtensions = { ".jpg", ".jpeg", ".gif", ".png" };

                var fileName = myFile.FileName.ToLower();
                var isValidExtenstion = imageExtensions.Any(ext => {
                    return fileName.LastIndexOf(ext) > -1;
                });

                if(isValidExtenstion) {
                    var path = GetOrCreateUploadFolder();
                    using(var fileStream = System.IO.File.Create(Path.Combine(path, myFile.FileName))) {
                        myFile.CopyTo(fileStream);
                    }
                }
            } catch {
                Response.StatusCode = 400;
            }
            return new EmptyResult();
        }
    }
}
