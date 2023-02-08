using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    public class DocumentProviderWasm : IDocumentProvider {
        HttpClient httpClient;

        public DocumentProviderWasm(HttpClient httpClient) {
            this.httpClient = httpClient;
        }

        public async Task<byte[]> GetDocumentAsync(string name, CancellationToken cancellationToken = default) {
            string base64 = await httpClient.GetStringAsync($"api/get-file-async?name={name}", cancellationToken);
            return Convert.FromBase64String(base64);
        }
    }
}
