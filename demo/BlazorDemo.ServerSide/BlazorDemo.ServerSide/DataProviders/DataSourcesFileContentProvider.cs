using System;
using System.IO;
using System.Threading.Tasks;

namespace BlazorDemo.Wasm.Server.DataProviders {
    public interface IDataSourcesFileContentProvider {
        public Task<string> GetFileSystemDataItemsContentAsync();
    }

    public class DataSourcesFileContentProvider : IDataSourcesFileContentProvider {
        string _fileSystemDataItemsContent;

        public async Task<string> GetFileSystemDataItemsContentAsync() {
            if(_fileSystemDataItemsContent == null) {
                string pathToDataFile = Path.Combine(AppContext.BaseDirectory, "DataSources", "FileSystemDataItems.json");
                _fileSystemDataItemsContent = await File.ReadAllTextAsync(pathToDataFile);
            }
            return _fileSystemDataItemsContent;
        }
    }
}
