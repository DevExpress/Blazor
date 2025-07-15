namespace BlazorDemo.Data;

public class PromptSuggestion {
    public PromptSuggestion(string title, string text, string promptMessage) {
        Title = title;
        Text = text;
        PromptMessage = promptMessage;
    }
    public string Title { get; set; }
    public string Text { get; set; }
    public string PromptMessage { get; set; }
}
