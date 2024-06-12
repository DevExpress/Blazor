using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IFileSystemDataProvider {
        public Task<List<FileSystemDataItem>> GetRootItemsAsync();
    }
}
