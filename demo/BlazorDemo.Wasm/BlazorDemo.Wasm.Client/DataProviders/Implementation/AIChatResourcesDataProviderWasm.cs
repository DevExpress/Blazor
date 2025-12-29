using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Wasm.DataProviders.Implementation;

#pragma warning disable DX0006
public class AIChatResourcesDataProviderWasm(HttpClient httpClient) : IChatResourcesDataProvider {
    public async Task<string> GetLogResourceContents(CancellationToken ct) => await httpClient.GetStringAsync($"api/{AIChatResourcesEndpoints.LogResourceEndpoint}", ct);
    public async Task<byte[]> GetImageResourceContents(CancellationToken ct) => await httpClient.GetByteArrayAsync($"api/{AIChatResourcesEndpoints.ImageResourceEndpoint}", ct);
    public async Task<string> GetDocsResourceContents(CancellationToken ct) => await httpClient.GetStringAsync($"api/{AIChatResourcesEndpoints.DocsResourceEndpoint}", ct);
}
#pragma warning restore DX0006
