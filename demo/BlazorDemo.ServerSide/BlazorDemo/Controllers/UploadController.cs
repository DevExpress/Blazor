using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Components;
using BlazorDemo.Configuration;

namespace BlazorDemo.AspNetCoreHost {
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public partial class UploadController : ControllerBase {
        private IWebHostEnvironment HostingEnvironment { get; set; }
        /*BeginHide*/
        private DemoConfiguration Configuration { get; set; }
        /*EndHide*/

        public UploadController(IWebHostEnvironment hostingEnvironment/*BeginHide*/, DemoConfiguration configuration/*EndHide*/) {
            HostingEnvironment = hostingEnvironment;
            /*BeginHide*/
            Configuration = configuration;
            /*EndHide*/
        }

        [HttpPost("[action]")]
        public ActionResult UploadFile(IFormFile myFile) {
            /*BeginHide*/
            if(!Configuration.SiteMode) {
            /*EndHide*/
            try {
                var path = Path.Combine(HostingEnvironment.ContentRootPath, "uploads");
                if(!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                using(var fileStream = System.IO.File.Create(Path.Combine(path, myFile.FileName))) {
                    myFile.CopyTo(fileStream);
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
