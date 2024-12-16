Set the [ShowSearchBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2.ShowSearchBox) property to `true` to display the search box in the List Box component. Once a user enters text in the search box, the List Box looks for the text in visible data column cells, filters, and highlights search results. The search is case-insensitive.

You can use the [SearchText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2.SearchText) property to specify the search text in code. Handle the [SearchTextChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2.SearchTextChanged) event to respond to search text changes. If the search text contains multiple words separated by space characters, words can be treated as a single condition or individual conditions. Set the [SearchTextParseMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2.SearchTextParseMode) property to one of the following values to specify how the List Box control treats search words:

* **GroupWordsByAnd** — The control searches for individual words. A record must include all search words.
* **GroupWordsByOr** — The control searches for individual words. A record needs to include at least one word. 
* **ExactMatch** — The control looks for exact matches of the entire search text.

For more information, refer to the following help topic: [Search and Filter Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2#search-and-filter-data).