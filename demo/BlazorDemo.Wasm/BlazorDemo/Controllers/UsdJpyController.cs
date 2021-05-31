using System.Threading.Tasks;
using BlazorDemo.Wasm.Server.DataProviders;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.Wasm.Server.Controllers {
    [Route("api")]
    [ApiController]
    public class UsdJpyController : Controller {
        public IUsdJpyCsvFileContentProvider Provider { get; set; }

        public UsdJpyController(IUsdJpyCsvFileContentProvider provider) {
            Provider = provider;
        }

        [HttpGet("get-usdjpy-exchange-data")]
        public async Task<string> GetUsdJpy() {
            return await Provider.GetFileContentAsync();
        }
    }
}
