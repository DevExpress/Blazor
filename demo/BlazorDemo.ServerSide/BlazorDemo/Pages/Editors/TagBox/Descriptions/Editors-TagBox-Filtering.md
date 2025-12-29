The DevExpress Blazor [TagBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2) allows users to filter data. When a user enters text in the edit box, the TagBox searches for this text in all visible columns, filters items, and highlights matches.

Users can use [special characters](xref:DevExpress.Blazor.Base.DxDropDownListEditorBase`2.SearchMode#search-syntax) to create composite criteria.

You can use the following API members to configure search and filter capabilities:

* [SearchMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDropDownListEditorBase-2.SearchMode) — Specifies search mode. **AutoSearch** is the default mode. You can set this property to **Disabled** to prevent search operations.
* [SearchFilterCondition](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDropDownListEditorBase-2.SearchFilterCondition) — Specifies search/filter condition (**Contains**/**Default**, **Equals**, or **StartsWith**).
* [SearchTextParseMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDropDownListEditorBase-2.SearchTextParseMode) — Specifies how the TagBox treats search words. If search text contains multiple words separated by space characters, words can be treated as a single condition or individual conditions. The following text parse modes are available: **GroupWordsByAnd**, **GroupWordsByOr**, and **ExactMatch**.
* [SearchEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListEditorColumn.SearchEnabled) — Specifies whether the component can search text in current column cells.
* [SearchDelay](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2.SearchDelay) — Specifies the delay between the last input in the edit box and initiation of the search operation.

For additional information, refer to the following help topic: [Search and Filter Data](https://docs.devexpress.com/Blazor/405477/components/data-editors/tagbox/data-shaping#search-and-filter-data).

