using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Components;
using BlazorDemo.Configuration;

namespace BlazorDemo.AspNetCoreHost {
    public partial class UploadController : ControllerBase {
        [HttpPost("[action]")]
        public ActionResult UploadFile(IFormFile myFile) {
            try {
                var path = GetOrCreateUploadFolder();
                using(var fileStream = System.IO.File.Create(Path.Combine(path, myFile.FileName))) {
                    myFile.CopyTo(fileStream);
                }
            } catch {
                Response.StatusCode = 400;
            }
            return new EmptyResult();
        }
    }
}
