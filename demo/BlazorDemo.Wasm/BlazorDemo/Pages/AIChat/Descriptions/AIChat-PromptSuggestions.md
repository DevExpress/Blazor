<div class="alert dxbl-alert alert-primary" role="alert">Note: AI services used for this demo have been rate limited. As such, you may experience performance-related delays when exploring the capabilities of DevExpress AI-powered Extensions.
<br />When connected to your own AI model/service without rate limits, DevExpress AI-powered Extensions will perform seamlessly, without artificial delays.</div>

DevExpress Blazor AI Chat supports prompt suggestions – hints that guide users to possible actions. The component displays prompt suggestions (hint bubbles) when the chat area is empty.
 
Follow the steps below to enable and configure prompt suggestions:
1. Populate the component's [PromptSuggestions](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Chat.DxAIChat.PromptSuggestions) property with [DxAIChatPromptSuggestion](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Chat.DxAIChatPromptSuggestion) objects (hint bubbles).
2. Specify bubble content using [Title](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Chat.DxAIChatPromptSuggestion.Title) and [Text](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Chat.DxAIChatPromptSuggestion.Text) properties.
3. Use the [PromptMessage](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Chat.DxAIChatPromptSuggestion.PromptMessage) property to specify the text to be displayed in the input field after a user clicks the corresponding suggestion.

In this demo, the [Initialized](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Chat.DxAIChat.Initialized) event handler supplies prompt suggestion content during chat initialization.
