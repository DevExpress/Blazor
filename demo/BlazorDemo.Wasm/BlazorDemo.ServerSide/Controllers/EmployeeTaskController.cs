using System.Linq;
using System.Text.Json;
using BlazorDemo.DataProviders;
using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.AspNetCoreHost {
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeTaskController : Controller {

        public EmployeeTaskController(IEmployeeTaskDataProvider dataProvider) {
            DataProvider = dataProvider;
        }

        IEmployeeTaskDataProvider DataProvider { get; }

        [HttpGet]
        public ActionResult GetTasks(DataSourceLoadOptions loadOptions) {
            var tasks = DataProvider.GenerateLargeData().AsQueryable();
            return Json(DataSourceLoader.Load(tasks, loadOptions), new JsonSerializerOptions());
        }
    }
}
