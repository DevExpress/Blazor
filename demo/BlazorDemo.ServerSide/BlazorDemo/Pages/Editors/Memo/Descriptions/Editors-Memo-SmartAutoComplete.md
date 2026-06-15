<div class="alert dxbl-alert alert-primary" role="alert">AI services used for this demo have been rate limited. As such, you may experience performance-related delays when exploring the capabilities of DevExpress AI-powered Extensions.
<br />When connected to your own AI model/service without rate limits, DevExpress AI-powered Extensions will perform seamlessly, without artificial delays.</div>

This demo incorporates an AI-powered [Smart Autocomplete extension](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Editors.MemoSmartAutoComplete) into the DevExpress Blazor Memo component. The extension helps users compose text more efficiently. As users type, an AI service analyzes their input and context, and generates relevant text suggestions.

To try autocomplete suggestions in this demo, place the caret at the end of existing text and start typing. You can interact with suggestions in the following ways:

* Press **Tab** to apply a suggestion.
* Press **Esc** or **Backspace**, continue typing, or click outside the editor to dismiss a suggestion.

Follow the steps below to reproduce the capabilities of this demo in your Blazor project:

1. Register the desired AI service in your application. Select the approach that best fits your needs:

    * [Use the DevExpress Template Kit](https://docs.devexpress.com/Blazor/405228/ai-powered-extensions) to create a new project with pre-configured AI services and NuGet packages.
    * [Integrate](https://docs.devexpress.com/Blazor/405228/ai-powered-extensions#manual-ai-services-integration) the desired AI service into your existing application.

2. Register the [DevExpress.AIIntegration.Blazor.Editors](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Editors) namespace in the _Components/Imports.razor_ file or in your Razor file.
3. Use the [Extensions](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMemo.Extensions) property to add the AI-powered Smart Autocomplete functionality to the Memo editor.


**Note:** DevExpress AI-powered extensions follow the "bring your own key" principle. DevExpress does not offer a REST API and does not ship any built-in LLMs/SLMs. You need an active Azure/Open AI subscription to obtain the REST API endpoint, key, and model deployment name. These variables must be specified at application startup to register AI clients and enable DevExpress AI-powered extensions in your application.
