The DevExpress Blazor [ListBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2) displays an empty data area in the following cases:

* The [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2.Data) property is unset.
* The specified data source does not contain items.
* You use the [DataAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2.DataAsync) property or the [CustomData](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2.CustomData) property to bind the List Box to a data source. The component sends the first request to a remote data source and waits for a response.

Define the [EmptyDataAreaTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2.EmptyDataAreaTemplate) to customize content displayed in the empty data area. The template's **context** parameter includes the [IsDataLoading](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxEmptyDataAreaTemplateContext.IsDataLoading) property that allows you to determine whether the List Box data is still loading data.