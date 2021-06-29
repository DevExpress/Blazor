using BlazorDemo.DataProviders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemo.AspNetCoreHost {
    [Route("api/[controller]/[action]")]
    public partial class NwindController : Controller {
        IDbContextFactory<NorthwindContext> _contextFactory;

        public NwindController(IDbContextFactory<NorthwindContext> contextFactory) {
            _contextFactory = contextFactory;
        }
    }
}
