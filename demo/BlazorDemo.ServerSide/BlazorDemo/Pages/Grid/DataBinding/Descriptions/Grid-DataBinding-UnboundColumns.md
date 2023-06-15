Our Blazor [Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid) allows you to add [unbound columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.UnboundType) whose values are not stored in the assigned data source. Unbound columns should use [FieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.FieldName) values that do not match field names in the Grid's data source.

You can populate unbound columns with data in two ways:

* Specify the [UnboundExpression](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.UnboundExpression) property to calculate unbound column values based on other column values. In this example, the **Total** column uses this property to calculate its values.
* Handle the [UnboundColumnData](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.UnboundColumnData) event to specify column values based on custom logic. In this example, the **Discount** column uses this event to populate associated cells. The event handler increases the discount price by 10% if seven or more days have passed between order date and ship date.

