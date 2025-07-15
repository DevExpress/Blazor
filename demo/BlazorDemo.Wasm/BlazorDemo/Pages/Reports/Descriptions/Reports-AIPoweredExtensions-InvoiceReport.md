<div class="alert dxbl-alert alert-primary" role="alert">Note: AI services used for this demo have been rate limited. As such, you may experience performance-related delays when exploring the capabilities of DevExpress AI-powered Extensions.
<br />When connected to your own AI model/service without rate limits, DevExpress AI-powered Extensions will perform seamlessly, without artificial delays.</div>

This demo incorporates AI-powered **Summarize**, **Translate**, and **Translate Inline** commands into the DevExpress Report Viewer.

You can use the following UI elements to leverage these AI-powered commands:

* **AI Operations** tab

    Select the **AI Operations** tab in the tab panel. Select input content range and desired output language. Click **Translate** or **Summarize**. Auto-generated summary/translation will appear in the same panel.

* AI-powered **Quick Actions** menu

    To access the **Quick Actions** menu, use the glyph next to the top-right corner of the page. The menu allows you to summarize/translate the current page or entire document. You can also select report content to summarize or translate. After selection, click the icon in the preview window to access AI-powered commands.

    **Summarize** and **Translate** commands display summary/translation within the **AI Operations** tab. 
    **Translate Inline** displays translations within the previewed document. You can export and/or print a report with translations.
   
Note: DevExpress AI-powered Extensions follow the "bring your own key" principle. DevExpress does not offer a REST API and does not ship any built-in LLMs/SLMs. You need an active Azure/Open AI subscription to obtain the REST API endpoint, key, and model deployment name. These variables must be specified at application startup to register AI clients and enable DevExpress AI-powered Extensions in your application.

[Documentation (Native Report Viewer)](https://docs.devexpress.com/XtraReports/405197/ai-powered-functionality/web-reporting/summarize-translate-in-blazor-viewer)

[Documentation (JavaScript-based Report Viewer)](https://docs.devexpress.com/XtraReports/405196/ai-powered-functionality/web-reporting/summarize-translate-in-web-viewer)
