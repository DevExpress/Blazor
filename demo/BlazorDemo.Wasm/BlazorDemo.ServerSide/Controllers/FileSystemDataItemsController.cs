using System.Threading.Tasks;
using BlazorDemo.Wasm.Server.DataProviders;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.Wasm.Server.Controllers {
    [Route("api")]
    [ApiController]
    public class FileSystemDataItemsController : Controller {
        public FileSystemDataItemsController(IDataSourcesFileContentProvider fileContentProvider) {
            FileContentProvider = fileContentProvider;
        }

        IDataSourcesFileContentProvider FileContentProvider { get; }

        [HttpGet("get-file-system-data-items")]
        public async Task<string> GetFileSystemDataItems() {
            return await FileContentProvider.GetFileSystemDataItemsContentAsync();
        }
    }
}
