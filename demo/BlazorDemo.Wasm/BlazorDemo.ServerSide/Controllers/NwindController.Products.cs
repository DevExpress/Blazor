using System.Text.Json;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.AspNetCoreHost {
    public partial class NwindController : Controller {
        [HttpGet]
        public async Task<IActionResult> GetProducts(DataSourceLoadOptions loadOptions) {
            // If underlying data is a large SQL table, specify PrimaryKey and PaginateViaPrimaryKey.
            // This can make SQL execution plans more efficient.
            loadOptions.PrimaryKey = new[] { "ProductId" };
            loadOptions.PaginateViaPrimaryKey = true;

            // Use your IDbContextFactory instance instead of _contextFactory
            using(var ctx = _contextFactory.CreateDbContext()) {
                var loadResult = await DataSourceLoader.LoadAsync(ctx.Products, loadOptions);
                return Json(loadResult, new JsonSerializerOptions());
            }
        }
    }
}
