using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DemoData;
using BlazorDemo.DataProviders;
using System.Net.Http;

namespace BlazorDemo.DataProviders.Implementation {
    public class FileSystemDataProviderWasm : IFileSystemDataProvider {
        List<FileSystemDataItem> _rootItems;

        public FileSystemDataProviderWasm(HttpClient httpClient) {
            HttpClient = httpClient;
        }

        HttpClient HttpClient { get; }

        public async Task<List<FileSystemDataItem>> GetRootItemsAsync() {
            if(_rootItems == null) {
                var json = await HttpClient.GetStringAsync("api/get-file-system-data-items");
                _rootItems = JsonSerializer.Deserialize<List<FileSystemDataItem>>(json);
            }
            return _rootItems;
        }
    }
}
