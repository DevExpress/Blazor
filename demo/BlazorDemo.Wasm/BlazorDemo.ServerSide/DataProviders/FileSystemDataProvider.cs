using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DemoData;
using BlazorDemo.DataProviders;
using BlazorDemo.Wasm.Server.DataProviders;

namespace BlazorDemo.DataProviders.Implementation {
    public class FileSystemDataProvider : IFileSystemDataProvider {
        List<FileSystemDataItem> _rootItems;

        public FileSystemDataProvider(IDataSourcesFileContentProvider fileContentProvider) {
            FileContentProvider = fileContentProvider;
        }

        IDataSourcesFileContentProvider FileContentProvider { get; }

        public async Task<List<FileSystemDataItem>> GetRootItemsAsync() {
            if(_rootItems == null) {
                var json = await FileContentProvider.GetFileSystemDataItemsContentAsync();
                _rootItems = JsonSerializer.Deserialize<List<FileSystemDataItem>>(json);
            }
            return _rootItems;
        }
    }
}
