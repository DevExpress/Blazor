<div class="alert dxbl-alert alert-primary" role="alert">Note: AI services used for this demo have been rate limited. As such, you may experience performance-related delays when exploring the capabilities of DevExpress AI-powered Extensions.
<br />When connected to your own AI model/service without rate limits, DevExpress AI-powered Extensions will perform seamlessly, without artificial delays.</div>

This demo incorporates AI-powered **Translate** and **Summarize** commands into the DevExpress Report Viewer. Both actions allow you to specify input content range (the entire document or a part of the document) and output language.

You can use the following UI elements to leverage these AI-powered commands:

- **AI Operations** tab

    Select the **AI Operations** tab in the tab panel. Select input content range and/or desired output language. Click **Translate** or **Summarize** (Auto-generated summary/translated text will appear within the **AI Operations** tab)

- AI-powered Extension context menu

    Select report content you wish to summarize or translate. After selection, click the icon that appears within the preview window. Select **Translate** or **Summarize** using the context menu (Auto-generated summary/translated text will appear within the **AI Operations** tab)

Note: DevExpress AI-powered Extensions follow the "bring your own key" principle. DevExpress does not offer a REST API and does not ship any built-in LLMs/SLMs. You need an active Azure/Open AI subscription to obtain the REST API endpoint, key, and model deployment name. These variables must be specified at application startup to register AI clients and enable DevExpress AI-powered Extensions in your application. 

[Documentation (Native Report Viewer)](https://docs.devexpress.com/XtraReports/405197/ai-powered-functionality/summarize-translate-in-blazor-viewer)

[Documentation (JavaScript-based Report Viewer)](https://docs.devexpress.com/XtraReports/405196/ai-powered-functionality/summarize-translate-in-web-viewer)
