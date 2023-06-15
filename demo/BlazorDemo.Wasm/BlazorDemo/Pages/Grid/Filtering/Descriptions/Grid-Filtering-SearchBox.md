The DevExpress Blazor [Grid](https://docs.devexpress.com/Blazor/403143/grid) ships with an integrated Search Box. Users can enter search strings/text within the Search Box to filter and highlight data.

Set the [ShowSearchBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ShowSearchBox) property to `true` to display the Search Box above column headers. If the group panel is visible, the Search Box is displayed within the group panel.

Use the [SearchText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SearchText) property to specify search text in code. You can handle the [SearchTextChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SearchTextChanged) event to respond to search text changes. The event is handled automatically when you use [two-way data binding](https://docs.devexpress.com/Blazor/402330/common-concepts/two-way-data-binding) for the [SearchText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SearchText) property (@bind-SearchText). 

If search text contains multiple words separated by space characters, words can be treated as a single condition or individual conditions. Set the [SearchTextParseMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SearchTextParseMode) property to one of the following values to specify how the Grid control treats search words.

* **GroupWordsByAnd** — Search words are treated as individual conditions grouped by the AND logical operator. Only records that match all conditions are displayed.
* **GroupWordsByOr** — Search words are treated as individual conditions grouped by the OR logical operator. Records that match at least one of these conditions are displayed.
* **ExactMatch** — Search words are not treated separately. Only records that match search text exactly are displayed.

Additionally, search text can include [special characters](https://docs.devexpress.com/Blazor/404142/grid/filter-data/search-box#search-syntax). Special characters allow users to create composite criteria.

The Grid control attempts to locate search text in every visible data column. You can use the [SearchEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.SearchEnabled) property to exclude a specific column from search operations.

The following members allow you to customize Search Box functionality.

* [SearchBoxInputDelay](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SearchBoxInputDelay) — Specifies the time interval between the last character entered in the Search Box and subsequent search text update.
* [SearchBoxNullText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SearchBoxNullText) — Specifies the prompt text displayed in the Search Box when it is empty.
* [CustomizeElement](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomizeElement) — Allows you to customize Search Box style settings.
* [SearchBoxTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SearchBoxTemplate) — Allows you to implement custom content for the Search Box.
* [SearchText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SearchText) — Allows you to implement an external Search Box and bind its value to the grid search text.
* [SearchTextChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SearchTextChanged) — Fires each time the search text changes and allows you to create a custom response to search text changes.

For more information about our Blazor Data Grid and its built-in search capabilities, refer to the following topic: [Search Box](https://docs.devexpress.com/Blazor/404142/grid/filter-data/search-box).
