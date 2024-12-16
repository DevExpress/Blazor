The DevExpress Blazor [ComboBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2) displays an “empty data area” in the following instances:

* The [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxListEditorBase-2.Data) property is not set.
* The specified data source is empty.
* None of the ComboBox items matches the current [search and filter condition](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDropDownListEditorBase-2.SearchFilterCondition).
* You use the [DataAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxListEditorBase-2.DataAsync) or [CustomData](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxListEditorBase-2.CustomData) property to bind the ComboBox to a data source. The component sends the first request to a remote data source and waits for a response.

Define the [EmptyDataAreaTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2.EmptyDataAreaTemplate) to customize the content displayed in this empty region. The template's **context** parameter includes the [IsDataLoading](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxEmptyDataAreaTemplateContext.IsDataLoading) property. This property allows you to determine whether ComboBox is loading data.
