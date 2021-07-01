using System.Threading.Tasks;
using BlazorDemo.Wasm.Server.DataProviders;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.Wasm.Server.Controllers {
    [Route("api")]
    [ApiController]
    public class WeatherSummaryController : Controller {
        public IWeatherSummaryCsvFileContentProvider Provider { get; set; }

        public WeatherSummaryController(IWeatherSummaryCsvFileContentProvider provider) {
            Provider = provider;
        }

        [HttpGet("get-weather-summary")]
        public async Task<string> GetWeatherSummary() {
            return await Provider.GetFileContentAsync();
        }
    }
}
