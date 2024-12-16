using BlazorDemo.Services;
using BlazorDemo.DataProviders;
using Microsoft.Extensions.DependencyInjection;
using System.ClientModel;
using Azure.AI.OpenAI;

public class Startup {
    public void ConfigureServices(IServiceCollection services) {
        // ...
        services.AddSingleton<AzureOpenAIClient>(_ => new AzureOpenAIClient(new Uri("Url"), new ApiKeyCredential("ApiKey")));
        services.AddSingleton<SmartFilterProvider>();
        services.AddSingleton<DictionaryEntryDataProvider>();
    }
}
