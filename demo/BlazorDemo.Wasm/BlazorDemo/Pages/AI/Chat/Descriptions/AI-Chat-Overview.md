<div class="alert dxbl-alert alert-primary" role="alert">Note: AI services used for this demo have been rate limited. As such, you may experience performance-related delays when exploring the capabilities of DevExpress AI-powered Extensions.
<br />When connected to your own AI model/service without rate limits, DevExpress AI-powered Extensions will perform seamlessly, without artificial delays.</div>

DevExpress AI Chat for Blazor is an AI-enabled chat component that allows users to interact with multiple AI services. Our Blazor Chat component can be integrated with the following AI services:

* OpenAI
* Azure OpenAI
* Ollama

To add the [DxAIChat](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Chat.DxAIChat) component to your application, register the appropriate AI service at application startup.

Enable the [UseStreaming](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Chat.DxAIChat.UseStreaming) property for a more responsive chat experience. This setting allows the AI client to send parts of a response once they become available (our Blazor Chat component will update the display message accordingly).

Note: DevExpress AI-powered extensions follow the "bring your own key" principle. DevExpress does not offer a REST API and does not ship any built-in LLMs/SLMs. You need an active Azure/Open AI subscription to obtain the REST API endpoint, key, and model deployment name. These variables must be specified at application startup to register AI clients and enable DevExpress AI-powered Extensions in your application.
