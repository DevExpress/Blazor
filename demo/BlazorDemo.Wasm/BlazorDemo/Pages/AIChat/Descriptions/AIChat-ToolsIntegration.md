<div class="alert dxbl-alert alert-primary" role="alert">Note: AI services used for this demo have been rate limited. As such, you may experience performance-related delays when exploring the capabilities of DevExpress AI-powered Extensions.
<br />When connected to your own AI model/service without rate limits, DevExpress AI-powered Extensions will perform seamlessly, without artificial delays.</div>

The DevExpress AI Chat component can transform natural language input into application logic. This feature relies on AI Tools — specifically annotated methods that define their purpose, input parameters, and the target object against which they operate. Users can trigger UI updates or business workflows by entering requests in the chat.

This demo features the DevExpress [AI tool calling layer](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Chat.DxAIChat#ai-tool-calling) that significantly extends Microsoft.Extensions.AI capabilities:

- **Context-aware targets**: Tools can operate on specific Blazor components, data services, and business objects. The API automatically resolves the correct target instance at runtime.
- **Dynamic availability**: Tools can be programmatically enabled, disabled, or removed based on current application state or user workflow.
- **Visual feedback**: The AI Chat component includes a built-in UI that visualizes tool selection and execution process.