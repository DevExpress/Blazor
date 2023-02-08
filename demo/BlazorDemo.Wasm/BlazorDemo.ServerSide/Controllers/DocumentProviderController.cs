using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BlazorDemo.DataProviders;
using BlazorDemo.Wasm.Server.DataProviders;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.Wasm.Server.Controllers {
    [Route("api")]
    [ApiController]
    public class DocumentProviderController : Controller {
        public IDocumentProvider Provider { get; set; }

        public DocumentProviderController(IDocumentProvider provider) {
            Provider = provider;
        }

        [HttpGet("get-file-async")]
        public async Task<string> GetFileAsync([FromQuery] string name) {
            byte[] bytes = await Provider.GetDocumentAsync(name);
            return Convert.ToBase64String(bytes);
        }
    }
}
