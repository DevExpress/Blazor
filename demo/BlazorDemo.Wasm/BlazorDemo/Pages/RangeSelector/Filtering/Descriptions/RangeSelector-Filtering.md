You can use the [Range Selector](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxRangeSelector) component to filter data in other DevExpress Blazor components.

In this demo, the [DxGrid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid) component displays customer orders. The **Total** column's minimum/maximum values serve as start and end values for the Range Selector's [scale](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxRangeSelectorScale). To filter Grid data based on the selected range, you must:

1. Handle the Range Selector's [ValueChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxRangeSelector.ValueChanged) event.
2. In the handler, use event argument properties to obtain values of the selected range.
3. Create a criteria operator object based on obtained values and call the Grid's [SetFieldFilterCriteria](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SetFieldFilterCriteria(System.String-DevExpress.Data.Filtering.CriteriaOperator)) method (to apply filter).
