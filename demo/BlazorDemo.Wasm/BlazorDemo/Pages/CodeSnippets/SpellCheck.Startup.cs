using BlazorDemo.Services;
using Microsoft.Extensions.DependencyInjection;

public class Startup {
    public void ConfigureServices(IServiceCollection services) {
        // ...
        services.AddDevExpressBlazor().AddSpellCheck(opts => {
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
    }
}
