using BlazorDemo.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.AI;

public class Startup {
    public void ConfigureServices(IServiceCollection services) {
        // ...
        IChatClient asChatClient = new Azure.AI.OpenAI.AzureOpenAIClient(new Uri(azureOpenAIEndpoint),
            new System.ClientModel.ApiKeyCredential(azureOpenAIKey))
            .GetChatClient(deployment).AsIChatClient();
        services.AddSingleton(asChatClient);
        services.AddDevExpressAI(aiConfig =>
            aiConfig.AddBlazorReportingAIIntegration(reportingCfg => {
                reportingCfg
                    .AddTranslation(translationCfg => {
                        translationCfg
                            .EnableTranslation()
                            .EnableInlineTranslation()
                            .SetLanguages(new List<LanguageInfo>() {
                                            new LanguageInfo(){ Id = "es-ES", Text = "Spanish"},
                                            new LanguageInfo(){ Id = "de-DE", Text = "German"},
                            });
                    })
                    .AddSummarization(sumCfg => {
                        sumCfg.SetSummarizationMode(SummarizationMode.Abstractive);
                    });
            });
        );
    }
}
