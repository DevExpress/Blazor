<div class="alert dxbl-alert alert-primary" role="alert">Note: AI services used for this demo have been rate limited. As such, you may experience performance-related delays when exploring the capabilities of DevExpress AI-powered Extensions.
<br />When connected to your own AI model/service without rate limits, DevExpress AI-powered Extensions will perform seamlessly, without artificial delays.</div>

The DevExpress AI-powered extension for our Blazor HTML Editor adds AI-related commands to the editor’s toolbar. Commands are designed to process text/HTML content. Available predefined commands are as follows:

* **Ask AI Assistant** — allows a user to process text based on a custom prompt.
* **Change Style** — rewrites text using a specified style.
* **Change Tone** — rewrites text using a specified tone.
* **Expand** — expands text.
* **Explain** — explains text.
* **Proofread** — proofreads text.
* **Shorten** — shortens text.
* **Summarize** — summarizes text.
* **Translate** — translates text into the specified language.

To utilize DevExpress AI-powered extensions, you should register an AI service in your application.

Note: DevExpress AI-powered extensions follow the "bring your own key" principle. DevExpress does not offer a REST API and does not ship any built-in LLMs/SLMs. You need an active Azure/Open AI subscription to obtain the REST API endpoint, key, and model deployment name. These variables must be specified at application startup to register AI clients and enable DevExpress AI-powered extensions in your application.

Declare the [DxHtmlEditor.AdditionalItems](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxHtmlEditor.AdditionalItems) property and populate it with AI-related toolbar items to integrate the corresponding commands into the HTML Editor.
