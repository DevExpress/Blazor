using System.Threading.Tasks;
using BlazorDemo.DataProviders;
using BlazorDemo.Wasm.Server.DataProviders;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.Wasm.Server.Controllers {
    [Route("api")]
    [ApiController]
    public class VehiclesController : Controller {
        IVehiclesXmlFileContentProvider Provider { get; }

        public VehiclesController(IVehiclesXmlFileContentProvider provider) {
            Provider = provider;
        }

        [HttpGet("get-vehicles-sales-data")]
        public async Task<string> GetVehiclesSales() {
            return await Provider.GetFileContentAsync();
        }
    }
}
