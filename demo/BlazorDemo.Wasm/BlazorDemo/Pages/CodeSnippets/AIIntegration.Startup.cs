using BlazorDemo.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.AI;

public class Startup {
    public void ConfigureServices(IServiceCollection services) {
        // ...
        IChatClient asChatClient = new Azure.AI.OpenAI.AzureOpenAIClient(new Uri(azureOpenAIEndpoint),
            new System.ClientModel.ApiKeyCredential(azureOpenAIKey))
            .AsChatClient(deployment);
        services.AddSingleton(asChatClient);
        services.AddDevExpressAI();
    }
}
