using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorDemo.DataProviders.Implementation;

public class AIChatResourcesDataProvider : IChatResourcesDataProvider {
    string logContent;
    byte[] imageContent;
    string docsContent;

    string GetFilePath(string resourceName) => Path.Combine(AppContext.BaseDirectory, "DataSources", "ChatResources", resourceName);

    public async Task<string> GetLogResourceContents(CancellationToken ct) {
        if(logContent == null) {
            logContent = await File.ReadAllTextAsync(GetFilePath("access.txt"), ct);
        }
        return logContent;
    }
    public async Task<byte[]> GetImageResourceContents(CancellationToken ct) {
        if(imageContent == null) {
            imageContent = await File.ReadAllBytesAsync(GetFilePath("dashboard.jpg"), ct);
        }
        return imageContent;
    }
    public async Task<string> GetDocsResourceContents(CancellationToken ct) {
        if(docsContent == null) {
            docsContent = await File.ReadAllTextAsync(GetFilePath("dxaichat.md"), ct);
        }
        return docsContent;
    }
}
