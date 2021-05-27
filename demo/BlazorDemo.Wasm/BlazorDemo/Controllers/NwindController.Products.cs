using System.Text.Json;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.AspNetCoreHost {
    public partial class NwindController : Controller {
        [HttpGet]
        public async Task<IActionResult> GetProducts(DataSourceLoadOptions loadOptions) {
            // Use your DbContext instance instead of _context
            var loadResult = await DataSourceLoader.LoadAsync(_context.Products, loadOptions);
            return Json(loadResult, new JsonSerializerOptions());
        }
    }
}
