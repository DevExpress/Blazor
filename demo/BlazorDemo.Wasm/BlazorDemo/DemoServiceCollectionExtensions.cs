using System;
using System.Globalization;
using System.Reflection;
using BlazorDemo.Configuration;
using BlazorDemo.Services;
using DevExpress.Blazor.DocumentMetadata;
using DevExpress.Blazor.RichEdit.SpellCheck;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Options;


namespace BlazorDemo {

    public static class DemoServiceCollectionExtensions {
        public static void AddDemoServices(this IServiceCollection services) {
            services.AddScoped<WeatherForecastService>();
            services.AddScoped<RentInfoDataService>();
            services.AddScoped<ContosoRetailDataService>();
            services.AddScoped<NwindDataService>();
            services.AddScoped<IssuesDataService>();
            services.AddScoped<WorldcitiesDataService>();
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

            services.AddDocumentMetadata(ConfigureMetadata);
            services.AddSingleton<DemoConfiguration>();

            static void ConfigureMetadata(IServiceProvider sp, IDocumentMetadataCollection metadataCollection) {
                sp.GetService<DemoConfiguration>().ConfigureMetadata(metadataCollection);
            }
        }
    }
}
