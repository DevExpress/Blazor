<div class="alert dxbl-alert alert-primary" role="alert">Note: AI services used for this demo have been rate limited. As such, you may experience performance-related delays when exploring the capabilities of DevExpress AI-powered Extensions.
<br />When connected to your own AI model/service without rate limits, DevExpress AI-powered Extensions will perform seamlessly, without artificial delays.</div>

DevExpress AI Chat for Blazor is an AI-enabled chat component that allows users to interact with multiple AI services. Our Blazor Chat component can be integrated with the following AI services:

* OpenAI
* Azure OpenAI
* Ollama

To add the [DxAIChat](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Chat.DxAIChat) component to your application, register the desired AI service in your application. Select the approach that best fits your needs:

* [Use the DevExpress Template Kit](https://docs.devexpress.com/Blazor/405228/ai-powered-extensions) to create a new project with pre-configured AI services and NuGet packages.
* [Integrate](https://docs.devexpress.com/Blazor/405228/ai-powered-extensions#manual-ai-services-integration) the desired AI service into your existing application.

Use the following properties to customize the chat appearance:

- [ShowHeader](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Chat.DxAIChat.ShowHeader): Displays a customizable chat header and a **Clear Chat** button.
- [UseStreaming](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Chat.DxAIChat.UseStreaming): Allows the AI client to send parts of a response once they become available. The AI Chat component will update the display message accordingly for a more responsive chat experience.
- [AllowResizeInput](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Chat.DxAIChat.AllowResizeInput): Allows users to resize the Blazor AI Chat input box. If this property is set to `false`, the input box automatically resizes itself as a user types.

**Note:** DevExpress AI-powered extensions follow the "bring your own key" principle. DevExpress does not offer a REST API and does not ship any built-in LLMs/SLMs. You need an active Azure/Open AI subscription to obtain the REST API endpoint, key, and model deployment name. These variables must be specified at application startup to register AI clients and enable DevExpress AI-powered Extensions in your application.

