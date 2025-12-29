<div class="alert dxbl-alert alert-primary" role="alert">Note: AI services used for this demo have been rate limited. As such, you may experience performance-related delays when exploring the capabilities of DevExpress AI-powered Extensions.
<br />When connected to your own AI model/service without rate limits, DevExpress AI-powered Extensions will perform seamlessly, without artificial delays.</div>

AI Tool Calling allows Large Language Models (LLMs) to interact with your database files, APIs, and application logic. Instead of guessing an answer, the AI model selects the appropriate function from your code, and generates parameters needed to execute it.

Use the [IncludeFunctionCallInfo](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Chat.DxAIChat.IncludeFunctionCallInfo) property to automatically append AI tool execution details to the chat response. This feature allows you to debug and monitor how the LLM interacts with your system in real-time:

- Optimize AI tool definitions: Refine metadata to make your tools easier for the LLM to understand.
- Audit security: Identify when AI attempts to access sensitive or restricted data.
- Build trust: Demonstrate to users that the response is based on actual data processing, not a hallucination.