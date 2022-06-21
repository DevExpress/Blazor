using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorDemo.DataProviders {
    public class DocumentProvider : IDocumentProvider {
        public Task<byte[]> GetDocumentAsync(string name, CancellationToken cancellationToken = default(CancellationToken)) {
            return File.ReadAllBytesAsync(Path.Combine(AppContext.BaseDirectory, Path.Combine("Data", "Documents", name)), cancellationToken);
        }
    }
}
