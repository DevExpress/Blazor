<div class="alert dxbl-alert alert-primary" role="alert">Note: AI services used for this demo have been rate limited. As such, you may experience performance-related delays when exploring the capabilities of DevExpress AI-powered Extensions.
<br />When connected to your own AI model/service without rate limits, DevExpress AI-powered Extensions will perform seamlessly, without artificial delays.</div>

This demo incorporates semantic search into the DevExpress Blazor Grid. Semantic search finds results based on meaning rather than exact wording, understanding the context and intent behind a question or phrase. This allows your DevExpress-powered app to deliver more relevant answers by connecting related concepts, even if exact words differ.

To review the benefits of this feature, search for dictionary entries and their descriptions and use synonyms or generic descriptions instead of exact search strings (such as “clothing” instead of a specific product name). You can fine-tune the search results: use the **Similarity Factor** spin editor to change the search precision.

Follow the steps below to reproduce the capabilities of this demo in your Blazor project:

1. [Add AI libraries](https://devblogs.microsoft.com/dotnet/introducing-microsoft-extensions-ai-preview/) of your choice to the project. In this demo, we use OpenAI. 
2. Configure your Grid: bind it to data, create columns, enable all appropriate functionality. 
3. Add an external [Search Box](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSearchBox) to the [ToolbarTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ToolbarTemplate). 
4. In the [DxSearchBox.TextChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSearchBox.TextChanged) event handler, call the `Filter` method to find similarities between data items and the search string. Refer to the **SmartFilterProvider.cs** tab for implementation details. 
