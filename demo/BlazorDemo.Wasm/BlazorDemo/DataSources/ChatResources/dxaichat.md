---
    uid: DevExpress.AIIntegration.Blazor.Chat.DxAIChat
name: DxAIChat
type: Class
summary: An AI-powered chat component.
    syntax:
content: 'public class DxAIChat : DxComponentBase, IAsyncDisposable, IAIChat, INestedSettingsOwner'
seealso:
    - linkType: HRef
linkId: xref:DevExpress.AIIntegration.Blazor.Chat.DxAIChat._members
altText: DxAIChat Members
---
    DevExpress Blazor AI Chat (`<DxAIChat>`) is an AI-powered chat component that allows users to interact with AI services.

![|AI Chat](~/images/aichat/blazor-aichat-overview.png)

[!demo[AI Chat](https://demos.devexpress.com/blazor/AI/Chat)]
[!example[Add a DxAIChat component in Blazor, MAUI, WPF, and WinForms applications](https://github.com/DevExpress-Examples/devexpress-ai-chat-samples)]
[!example[Build a Multi-LLM Chat Application](https://github.com/DevExpress-Examples/blazor-ai-chat-with-multiple-llm-services)]
[!example[Implement Function/Tool Calling](https://github.com/DevExpress-Examples/blazor-ai-chat-function-calling)]

The DevExpress Blazor AI Chat component is compatible with major cloud AI providers and self-hosted language models. Its architecture also allows you to integrate custom AI providers or implement support for proprietary, in-house LLMs.

    For a complete list of supported AI providers and detailed integration instructions, see the following help topic: [](xref:405228).

[!include[](~/templates/ai-service-disclamer.md)]

### Add an AI Chat to a Project

Follow the steps below to add an AI Chat component to an application:

    1. Create a new Blazor Server or Blazor WebAssembly application with a [DevExpress Project Template](xref:401057). For existing Blazor projects or those created with a Microsoft template, [configure your project](xref:401986) to integrate DevExpress Blazor components.
2. Install NuGet packages and [register](xref:405228#ai-services-integration) the AI model in the project's entry point class.

In a typical setup, DevExpress Blazor AI Chat works with a single [IChatClient](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.ai.ichatclient). To offer a choice of AI services in your application, register multiple AI models using the [.NET keyed services](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection#keyed-services) mechanism. Each `IChatClient` is associated with a unique string key by calling the [AddKeyedChatClient](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.chatclientbuilderservicecollectionextensions.addkeyedchatclient) method.

```csharp
   public class Program
   {
       public static void Main(string[] args)
       {
           var builder = WebApplication.CreateBuilder(args);
           /* define chat clients */
           builder.Services.AddChatClient(azureOpenAIChatClient);
           builder.Services.AddKeyedChatClient("Gemini", geminiChatClient);
           builder.Services.AddKeyedChatClient("Ollama", ollamaChatClient);
           /* ... */
       }
   }
   ```

3. Add the following markup to a `.razor` file:

    ```Razor
    @using DevExpress.AIIntegration.Blazor.Chat
    <DxAIChat />
    ```

Use the @DevExpress.AIIntegration.Blazor.Chat.DxAIChat.ChatClientServiceKey property to dynamically bind the AI Chat component to a specific AI service at runtime. You can offer users a choice of AI models or programmatically select the most appropriate model for the task.

4. *Optional* Configure other model options (see sections below).

#### Security Considerations

Never hardcode an AI provider's access keys, credentials, or API endpoints directly into your source code. This creates a critical security vulnerability, as code can be accidentally exposed through public repositories, internal leaks, or insecure deployment logs. If compromised, these secrets could grant a threat actor direct access to your account, leading to potential data breaches, unauthorized service usage, and financial loss.

To mitigate these risks, adopt a secret management strategy. The recommended approach depends on your Blazor application's hosting model.

In a **Blazor Server** application, all application logic is executed on the server. This architecture provides a secure environment because secrets are never exposed to the client's browser.

- For local development, use the [User Secrets Manager](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets#secret-manager). This .NET tool stores sensitive data in a `secrets.json` file on your local machine, completely outside of your project folder. This ensures secrets are not accidentally committed to source control.
- Use environment variables to supply secrets to your application. You can set these variables on the host server or through a CI/CD pipeline.
- For the highest level of security, use [Azure Key Vault](https://azure.microsoft.com/en-us/products/key-vault) or an equivalent from another cloud provider. These services provide secure storage, access policies, and audit trails for all application secrets.

    **Blazor WebAssembly (WASM)** applications run entirely on the client's browser. This means any information stored within the application can be accessed by the user. Therefore, you should never store any secrets in a Blazor WASM application. The client-side nature of Blazor WASM also means it cannot directly access server-side environment variables. The most secure approach for Blazor WASM is to use a backend API as a proxy between your client-side application and the AI provider:

1. Develop a separate ASP.NET Core Web API or serverless function that will handle all communications with the third-party AI provider. When you create a new Blazor WASM project in Visual Studio, you have the option to include an ASP.NET Core hosted backend, which sets up this structure for you.
    2. This backend API will securely store and use the necessary access keys and credentials. Follow the server-side secret management practices for **Blazor Server** application.
3. Your Blazor WASM application will then [call](https://learn.microsoft.com/en-us/aspnet/core/blazor/call-web-api) your API instead of an external AI provider. The API, in turn, makes the authenticated requests to the external AI model. This pattern ensures that no sensitive information is exposed on the client-side.

### API Reference

Refer to the following list for the component API reference: [DxAIChat Members](xref:DevExpress.AIIntegration.Blazor.Chat.DxAIChat._members).

### Integration into WinForms, WPF, and .NET MAUI Apps

Use [Blazor Hybrid](xref:404118) technology to integrate DevExpress AI Chat into WinForms, WPF, or .NET MAUI applications. The following GitHub repository includes an implementation example: [Blazor AI Chat - How to add the DevExpress Blazor AI Chat component to your next Blazor, MAUI, WPF, and WinForms application](https://github.com/DevExpress-Examples/devexpress-ai-chat-samples).

### AI Model Settings

The `DxAIChat` component allows you to specify the following AI model settings:

    :  @DevExpress.AIIntegration.Blazor.Chat.DxAIChat.FrequencyPenalty
:  @DevExpress.AIIntegration.Blazor.Chat.DxAIChat.MaxTokens
:  @DevExpress.AIIntegration.Blazor.Chat.DxAIChat.Temperature

### Streaming Response

Enable the @DevExpress.AIIntegration.Blazor.Chat.DxAIChat.UseStreaming property for a more responsive chat experience. This setting allows the AI client to send parts of the response once they become available, and the chat component will update the display message accordingly.

    ```Razor
<DxAIChat UseStreaming="true" />
```

![AI chat streams a response](~/images/aichat/blazor-aichat-UseStreaming.gif)

[!demo[AI Chat - Overview](https://demos.devexpress.com/blazor/AI/Chat#Overview)]

### Rich Formatted Response

The AI service uses plain text as the default response format. To display rich formatted responses, set the @DevExpress.AIIntegration.Blazor.Chat.DxAIChat.ResponseContentFormat property to `Markdown` and use a markdown processor to convert response content to HTML code.

    ```Razor
@using Markdig;

<DxAIChat ResponseContentFormat="ResponseContentFormat.Markdown">
    <MessageContentTemplate>
            @ToHtml(context.Content)
    </MessageContentTemplate>
</DxAIChat>

@code {
    MarkupString ToHtml(string text) {
        return (MarkupString)Markdown.ToHtml(text);
    }
}
```

![|Rich formatter content in AI Chat](~/images/aichat/blazor-aichat-Markdown.png)

### File Attachments

    `<DxAIChat>` allows users to attach files when sending messages to the chat. Set the [DxAIChat.FileUploadEnabled](xref:DevExpress.AIIntegration.Blazor.Chat.DxAIChat.FileUploadEnabled) property to `true` to enable file upload operations.

![|AI Chat - File Attachments](~/images/aichat/blazor-aichat-file-attachments.png)

Once a user attaches files to a message, the AI Chat component validates attached files. To configure validation rules, declare a @DevExpress.AIIntegration.Blazor.Chat.DxAIChatFileUploadSettings object in @DevExpress.AIIntegration.Blazor.Chat.DxAIChat.AIChatSettings component markup. You can validate file [size](xref:DevExpress.AIIntegration.Blazor.Chat.DxAIChatFileUploadSettings.MaxFileSize), [extension](xref:DevExpress.AIIntegration.Blazor.Chat.DxAIChatFileUploadSettings.AllowedFileExtensions), and [type](xref:DevExpress.AIIntegration.Blazor.Chat.DxAIChatFileUploadSettings.FileTypeFilter) as well as limit the [number of files](xref:DevExpress.AIIntegration.Blazor.Chat.DxAIChatFileUploadSettings.MaxFileCount).

    [!include[<6-9>](~/templates/blazor-aichat-file-upload-settings-example.md)]

You can also use the @DevExpress.AIIntegration.Blazor.Chat.AIChatUploadFileInfo class to send messages with file attachments in code (via the `SendMessage` method) or access and process uploaded files in a `MessageSent` event handler.

    [!demo[AI Chat - File Attachments](https://demos.devexpress.com/blazor/AI/Chat#FileAttachments)]

    [!include[](~/templates/ai-service-file-format-notice.md)]

### Customizable Message Appearance and Empty Message Area

The `DxAIChat` component includes the following message customization properties:

@DevExpress.AIIntegration.Blazor.Chat.DxAIChat.MessageTemplate
:   Changes the message bubble rendering, including paddings and inner content alignment.
    @DevExpress.AIIntegration.Blazor.Chat.DxAIChat.MessageContentTemplate
:   Alters message bubble content without affecting layout.
    @DevExpress.AIIntegration.Blazor.Chat.DxAIChat.EmptyMessageAreaTemplate
:   Specifies the template used to display the message area if there are no message bubbles.

# [Razor](#tab/tabid-razor)
    ```Razor
<DxAIChat CssClass="demo-chat"
          Initialized="ChatInitialized"
          ResponseContentFormat="ResponseContentFormat.Markdown">
        <MessageContentTemplate>
            <div class="demo-chat-content">
                @(new MarkupString(Markdig.Markdown.ToHtml(context.Content).Trim()))
            </div>
        </MessageContentTemplate>
    </DxAIChat>
</div>

@code {
    void ChatInitialized(IAIChat chat) {
        chat.LoadMessages(new[] {
            new BlazorChatMessage(Microsoft.Extensions.AI.ChatRole.User, "Hello, AI!"),
            new BlazorChatMessage(Microsoft.Extensions.AI.ChatRole.Assistant, "Hey there, human! What's on your mind? 😊")
        });
    }
}

```

# [CSS](#tab/tabid-css)
    ```CSS
 .demo-chat {
    width: 100%;
    height: 400px;
}
     .demo-chat .demo-chat-content > p:last-child {
        margin-bottom: 0;
    }
```
***

![|AI chat with customized messages](~/images/aichat/blazor-aichat-MessageContentTemplate.png)

[!demo[AI Chat - Rich Formatted Response](https://demos.devexpress.com/blazor/AI/Chat#ContentTemplate)]

### Manual Message Processing

When a user sends a message to the chat, the @DevExpress.AIIntegration.Blazor.Chat.DxAIChat.MessageSent event fires. Handle the event to manually process this action.
    You can use the @DevExpress.AIIntegration.Blazor.Chat.MessageSentEventArgs.Content event argument to access user input and call the @DevExpress.AIIntegration.Blazor.Chat.DxAIChat.SendMessage(System.String,Microsoft.Extensions.AI.ChatRole,System.Collections.Generic.List{DevExpress.AIIntegration.Blazor.Chat.AIChatUploadFileInfo}) method to send another message to the chat.

    ```Razor
<DxAIChat MessageSent="MessageSent" />

@code {
    async Task MessageSent(MessageSentEventArgs args) {
        await args.Chat.SendMessage($"Processed: {args.Content}", ChatRole.Assistant);
    }
}

```

    [!demo[AI Chat - Manual Message Processing](https://demos.devexpress.com/blazor/AI/Chat#MessageHandling)]

### Stop Message Generation

Our Blazor AI Chat component allows users to stop chat message generation before it is complete. You can also use the @DevExpress.AIIntegration.Blazor.Chat.MessageSentEventArgs.CancellationToken argument property in a @DevExpress.AIIntegration.Blazor.Chat.DxAIChat.MessageSent event handler to process cancellations in code.

![AI Chat - Stop Chat Message Generation](~/images/aichat/blazor-aichat-stop-message-generation.gif)

[!demo[AI Chat - Overview](https://demos.devexpress.com/blazor/AI/Chat#Overview)]

### Save and Load Messages

Use [SaveMessages](xref:DevExpress.AIIntegration.Blazor.Chat.DxAIChat.SaveMessages) and [LoadMessages](xref:DevExpress.AIIntegration.Blazor.Chat.DxAIChat.LoadMessages(System.Collections.Generic.IEnumerable{DevExpress.AIIntegration.Blazor.Chat.BlazorChatMessage})) methods to manage chat history.

    ```Razor
<DxAIChat Initialized="ChatInitialized" />

@code {
    void ChatInitialized(IAIChat chat) {
        chat.LoadMessages(new[] {
            new BlazorChatMessage(Microsoft.Extensions.AI.ChatRole.Assistant, "Hello, how can I help you?")
        });
    }
}
```

![|Chat with a loaded message](~/images/aichat/blazor-aichat-loadMessages.png)

#### Add a System Prompt

    [!include[<[DxAIChat.Initialized](xref:DevExpress.AIIntegration.Blazor.Chat.DxAIChat.Initialized)>](~/templates/blazor-aichat-add-system-prompt.md)]

### Prompt Suggestions

    [!include[<@DevExpress.AIIntegration.Blazor.Chat.DxAIChat.PromptSuggestions><@DevExpress.AIIntegration.Blazor.Chat.DxAIChatPromptSuggestion>](~/templates/blazor-aichat-prompt-suggestions-info.md)]

[!demo[AI Chat – Prompt Suggestions](https://demos.devexpress.com/blazor/AI/Chat#PromptSuggestions)]

                                     [!include[<4,6-8>](~/templates/blazor-aichat-prompt-suggestions-example.md)]

Additionally, you can use the @DevExpress.AIIntegration.Blazor.Chat.DxAIChat.PromptSuggestionContentTemplate property to specify a template for prompt suggestions.

### AI Service Assistants

The DevExpress AI Chat component supports [OpenAI Assistants](https://platform.openai.com/docs/assistants/overview). You can use a single OpenAI Assistant instance to initiate multiple tasks within a single application. To connect the chat to an existing assistant, pass the asisstant and thread IDs to the @DevExpress.AIIntegration.Blazor.Chat.IAIChat.SetupAssistantAsync(System.String,System.String) method as parameters.

> [!Note]
> Availability of Azure Open AI Assistants depends on the region. Refer to the following article for more details: [Assistants (Preview)](https://learn.microsoft.com/en-us/azure/ai-services/openai/concepts/models?tabs=global-standard%2Cstandard-chat-completions#assistants-preview).

[!include[blazor-aichat-setup-assistant](~/templates/blazor-aichat-setup-assistant.md)]
