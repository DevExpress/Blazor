using System.Threading.Tasks;
using BlazorDemo.Wasm.Server.DataProviders;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.Wasm.Server.Controllers {
    [Route("api")]
    [ApiController]
    public class GlobalTemperatureIndexController : Controller {
        public IGlobalTemperatureIndexFileContentProvider Provider { get; set; }

        public GlobalTemperatureIndexController(IGlobalTemperatureIndexFileContentProvider provider) {
            Provider = provider;
        }

        [HttpGet("get-global-temperature-index")]
        public async Task<string> GetGlobalTemperatureIndex() {
            return await Provider.GetFileContentAsync();
        }
    }
}
