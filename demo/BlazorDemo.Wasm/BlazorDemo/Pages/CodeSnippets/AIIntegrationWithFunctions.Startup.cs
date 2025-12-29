using BlazorDemo.Services;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.DependencyInjection;

public class Startup {
    public void ConfigureServices(IServiceCollection services) {
        // ...
        IChatClient asChatClient = new Azure.AI.OpenAI.AzureOpenAIClient(new Uri(azureOpenAIEndpoint),
            new System.ClientModel.ApiKeyCredential(azureOpenAIKey))
            .GetChatClient(deployment).AsIChatClient();

        IChatClient functionalChatClient = new ChatClientBuilder(asChatClient)
             .ConfigureOptions(x => {
                 x.Tools = [CustomAIFunctions.GetWeatherTool, CustomAIFunctions.TestExceptionTool, CustomAIFunctions.GetTimeTool];
             })
             .UseFunctionInvocation()
             .Build();

        services.AddKeyedSingleton(ChatClientKeys.FunctionCalling, functionalChatClient);
        services.AddDevExpressAI();
    }
}
