using System.Threading;
using System.Threading.Tasks;

namespace BlazorDemo.DataProviders {
    public interface IDocumentProvider {
        public Task<byte[]> GetDocumentAsync(string name, CancellationToken cancellationToken = default(CancellationToken));
    }
}
