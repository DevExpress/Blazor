The DevExpress Blazor [List Box](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2) allows you to filter data in code. To apply filter criteria, create a criteria operator object that specifies a filter expression and send this object to the [SetFilterCriteria](DevExpress.Blazor.DxListBox-2.SetFilterCriteria(DevExpress.Data.Filtering.CriteriaOperator)) method. To obtain the applied filter criteria, use the [GetFilterCriteria](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2.GetFilterCriteria) method.

When a filter is applied, the ListBox raises its [FilterCriteriaChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2.FilterCriteriaChanged) event.

You can call the [ClearFilter](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2.ClearFilter) method to clear previously applied filters and apply a new filter to List Box data.

For more information, refer to the following help topic: [Filter Criteria](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2#filter-criteria).
