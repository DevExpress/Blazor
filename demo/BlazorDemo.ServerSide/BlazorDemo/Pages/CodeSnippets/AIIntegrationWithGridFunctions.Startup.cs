using BlazorDemo.Services;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.DependencyInjection;

public class Startup {
    public void ConfigureServices(IServiceCollection services) {
        // ...
        IChatClient asChatClient = new Azure.AI.OpenAI.AzureOpenAIClient(new Uri(azureOpenAIEndpoint),
            new System.ClientModel.ApiKeyCredential(azureOpenAIKey))
            .GetChatClient(deployment).AsIChatClient();

        services.AddKeyedScoped<IChatClient>(ChatClientKeys.FunctionCallingWithGrid, (provider, key) => {
            var baseClient = provider.GetService<IChatClient>();
            return baseClient.AsBuilder()
               .UseDXTools()
               .UseFunctionInvocation()
               .Build(provider);
        });
        services.AddDevExpressAI();
    }
}
