using BlazorDemo.DataProviders;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.AspNetCoreHost {
    [Route("api/[controller]/[action]")]
    public partial class NwindController : Controller {
        NorthwindContext _context;

        public NwindController(NorthwindContext context) {
            _context = context;
        }
    }
}
