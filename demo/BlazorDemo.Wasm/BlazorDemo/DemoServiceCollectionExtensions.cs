using System;
using System.Reflection;
using Azure.AI.OpenAI;
using BlazorDemo.Configuration;
using BlazorDemo.DataProviders;
using BlazorDemo.Services;
using DevExpress.Blazor.DocumentMetadata;
using DevExpress.Blazor.RichEdit.SpellCheck;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;


namespace BlazorDemo {

    public static class DemoServiceCollectionExtensions {
        public static void AddDemoServices(this IServiceCollection services, bool blazorWasm = false) {
            services.AddScoped<WeatherForecastService>();
            services.AddScoped<RentInfoDataService>();
            services.AddScoped<ContosoRetailDataService>();
            services.AddScoped<NwindDataService>();
            services.AddScoped<HomesDataService>();
            services.AddScoped<IssuesDataService>();
            services.AddScoped<WorldcitiesDataService>();
            services.AddScoped<DictionaryEntryDataProvider>();
            var azureOpenAIEndpoint = "https://public-api.devexpress.com/demo-openai"; //DevExpress proxy-server
            var azureOpenAIKey = "DEMO"; //Demo key

            var openAIClient = new AzureOpenAIClient(
                new Uri(azureOpenAIEndpoint),
                new System.ClientModel.ApiKeyCredential(azureOpenAIKey),
                new AzureOpenAIClientOptions() { Transport = new PromoteHttpStatusErrorsPipelineTransport() });

            var chatClient = openAIClient.GetChatClient("gpt-4o-mini").AsIChatClient();

            services.AddSingleton(chatClient);
            services.AddSingleton(openAIClient);
            services.AddDevExpressAI();
            services.AddSingleton<SmartFilterProvider>();
            services.AddDevExpressBlazor(opts => {
                opts.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5;
            }).AddSpellCheck(opts => {
                opts.FileProvider = new EmbeddedFileProvider(Assembly.GetExecutingAssembly(), "BlazorDemo");
                opts.MaxSuggestionCount = 6;
                opts.AddToDictionaryAction = (word, culture) => {
                    //Write the selected word to a dictionary file
                };
                opts.Dictionaries.Add(new ISpellDictionary {
                    DictionaryPath = "Data.Dictionaries.english.xlg",
                    GrammarPath = "Data.Dictionaries.english.aff",
                    Culture = "en-US"
                });
                opts.Dictionaries.Add(new Dictionary {
                    DictionaryPath = "Data.Dictionaries.custom.dic",
                    AlphabetPath = "Data.Dictionaries.english.txt",
                    Culture = "en-US"
                });
            });

            if(blazorWasm) {
                services.AddScoped<DevExpress.XtraReports.Services.IReportProviderAsync, DemoReportSourceWasm>();
                services.AddDevExpressWebAssemblyBlazorPdfViewer();
                services.AddDevExpressWebAssemblyBlazorReportViewer();

                DevExpress.XtraPrinting.PrintingOptions.Pdf.RenderingEngine = DevExpress.XtraPrinting.XRPdfRenderingEngine.Skia;
            }
            services.AddDocumentMetadata(ConfigureMetadata);
            services.AddSingleton<DemoConfiguration>();

            static void ConfigureMetadata(IServiceProvider sp, IDocumentMetadataCollection metadataCollection) {
                sp.GetService<DemoConfiguration>().ConfigureMetadata(metadataCollection);
            }
        }
    }
}
