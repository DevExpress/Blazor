using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.Wasm.Server.Controllers;

[Route("api")]
[ApiController]
public class AIChatResourcesController(IChatResourcesDataProvider provider) : Controller {
    IChatResourcesDataProvider Provider { get; } = provider;

    [HttpGet(AIChatResourcesEndpoints.LogResourceEndpoint)]
    public async Task<string> GetLogResourceContents() => await Provider.GetLogResourceContents(CancellationToken.None);

    [HttpGet(AIChatResourcesEndpoints.ImageResourceEndpoint)]
    public async Task<FileContentResult> GetImageResourceContents() {
        var bytes = await Provider.GetImageResourceContents(CancellationToken.None);
        return File(bytes, "image/jpeg");
    }

    [HttpGet(AIChatResourcesEndpoints.DocsResourceEndpoint)]
    public async Task<string> GetDocsResourceContents() => await Provider.GetDocsResourceContents(CancellationToken.None);
}

