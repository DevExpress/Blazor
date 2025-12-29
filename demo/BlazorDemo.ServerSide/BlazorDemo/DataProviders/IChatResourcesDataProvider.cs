using System.Threading;
using System.Threading.Tasks;

namespace BlazorDemo.DataProviders;

public interface IChatResourcesDataProvider {
    public Task<string> GetLogResourceContents(CancellationToken ct);
    public Task<byte[]> GetImageResourceContents(CancellationToken ct);
    public Task<string> GetDocsResourceContents(CancellationToken ct);
}
