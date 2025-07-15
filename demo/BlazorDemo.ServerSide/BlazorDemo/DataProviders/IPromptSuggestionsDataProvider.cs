using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IPromptSuggestionsDataProvider {
        public List<PromptSuggestion> GetData();
    }
}
