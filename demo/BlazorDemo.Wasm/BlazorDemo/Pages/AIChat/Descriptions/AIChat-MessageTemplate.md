<div class="alert dxbl-alert alert-primary" role="alert">Note: AI services used for this demo have been rate limited. As such, you may experience performance-related delays when exploring the capabilities of DevExpress AI-powered Extensions.
<br />When connected to your own AI model/service without rate limits, DevExpress AI-powered Extensions will perform seamlessly, without artificial delays.</div>

The DevExpress Blazor AI Chat component allows you to modify the appearance of message bubbles. Use the [MessageTemplate](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Chat.DxAIChat.MessageTemplate) property to display any UI render fragment within a chat message. This template changes how the message bubble is rendered, including paddings and inner content alignment.

The [BlazorChatMessage](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Chat.BlazorChatMessage) template context parameter includes details about the message being processed.

In this demo, the [Initialized](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Chat.DxAIChat.Initialized) event handler calls the [LoadMessages](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Chat.DxAIChat.LoadMessages(System.Collections.Generic.IEnumerable-DevExpress.AIIntegration.Blazor.Chat.BlazorChatMessage-)) method to load message history during chat initialization.
