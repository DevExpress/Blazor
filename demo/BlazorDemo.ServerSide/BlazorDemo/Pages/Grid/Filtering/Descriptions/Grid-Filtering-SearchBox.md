Set the [ShowSearchBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ShowSearchBox) property to `true` to display the Search Box in the DevExpress Blazor [Grid](https://docs.devexpress.com/Blazor/403143/grid). Users can enter search strings/text within the Search Box to filter and highlight data. The Grid control attempts to locate search text in every visible data column. You can use the [SearchEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.SearchEnabled) property to exclude a specific column from search operations.

Use the [SearchText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SearchText) property to specify search text in code. Handle the [SearchTextChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SearchTextChanged) event to respond to search text changes. If search text contains multiple words separated by space characters, words can be treated as a single condition or individual conditions. Set the [SearchTextParseMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SearchTextParseMode) property to one of the following values to specify how the Grid control treats search words.

* **GroupWordsByAnd** — Search words are treated as individual conditions grouped by the AND logical operator. Only records that match all conditions are displayed.
* **GroupWordsByOr** — Search words are treated as individual conditions grouped by the OR logical operator. Records that match at least one of these conditions are displayed.
* **ExactMatch** — Search words are not treated separately. Only records that match search text exactly are displayed.

In this demo, [keyboard navigation](https://docs.devexpress.com/Blazor/404652/components/grid/keyboard-support) is enabled. You can press Ctrl+F to move focus from a Grid element to the Search Box.

For more information about our Blazor Data Grid and its built-in search capabilities, refer to the following topic: [Search Box](https://docs.devexpress.com/Blazor/404142/grid/filter-data/search-box).
