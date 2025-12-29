namespace BlazorDemo.Data;

public class PromptSuggestion {
    public PromptSuggestion(string title, string text, string promptMessage, bool sendOnClick = false) {
        Title = title;
        Text = text;
        PromptMessage = promptMessage;
        SendOnClick = sendOnClick;
    }
    public string Title { get; set; }
    public string Text { get; set; }
    public string PromptMessage { get; set; }
    public bool SendOnClick { get; set; }
}
