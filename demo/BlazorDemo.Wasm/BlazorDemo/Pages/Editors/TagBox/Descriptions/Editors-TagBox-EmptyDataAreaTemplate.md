The DevExpress Blazor [TagBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2) displays an “empty data area” in the following instances:

* The [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDropDownListEditorBase-2.Data) property is not set.
* The specified data source does not contain items.
* You use the [DataAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.BaseDxDropDownListEditorBase-2.DataAsync) property or the [CustomData](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDropDownListEditorBase-2.CustomData) property to bind the List Box to a data source. The component sends the first request to a remote data source and waits for an appropriate response.

Define the [EmptyDataAreaTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2.EmptyDataAreaTemplate) to customize content displayed in this empty region. The template's **context** parameter includes the [IsDataLoading](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxEmptyDataAreaTemplateContext.IsDataLoading) property. This property allows you to determine whether TagBox is still loading data.