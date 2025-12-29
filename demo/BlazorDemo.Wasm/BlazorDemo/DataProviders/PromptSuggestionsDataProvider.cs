using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {
    public class PromptSuggestionsDataProvider : IPromptSuggestionsDataProvider {
        public List<PromptSuggestion> GetData() {
            List<PromptSuggestion> result =
            [
                new PromptSuggestion("Tell me a joke", "Take a break and enjoy a quick laugh", "Tell me a joke.", true),
                new PromptSuggestion("Summarize text", "Extract a quick summary (main ideas)", "Summarize the following text:"),
                new PromptSuggestion("Write an email", "Make your text look and sound professional", "Format text as a formal email to a client:"),
                new PromptSuggestion("Brainstorm ideas", "Get creative input for your tasks", "Help me brainstorm ideas for:"),
                new PromptSuggestion("Fix my writing", "Avoid spelling, grammar, and style errors", "Proofread the following text:"),
            ];

            return result;
        }
    }
}
