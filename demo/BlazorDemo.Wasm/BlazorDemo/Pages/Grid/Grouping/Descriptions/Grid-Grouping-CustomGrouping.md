The DevExpress Blazor [Grid](https://docs.devexpress.com/Blazor/403143/grid) component supports custom data grouping. Custom data groups allow you to merge data into custom intervals or combine similar values into a single entry. In this demo, the **Unit Price** column is grouped by custom range values: $0.00 — $10.00, $10.00 — $20.00, etc.

To implement your own custom grouping logic, you must:

1. Define a custom sorting algorithm (because grouping relies on sort operations). To apply a custom algorithm, set the [DxGridDataColumn.SortMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.SortMode) property to `Custom` and handle the [CustomSort](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomSort) event. In the event handler, compare column values to define associated order.
2. Set the [DxGridDataColumn.GroupInterval](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.GroupInterval) property to `Custom` and handle the [CustomGroup](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomGroup) event. In the event handler, compare column values to define whether they belong to the same group.
3. _(Optional)_ Handle the [CustomizeGroupValueDisplayText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomizeGroupValueDisplayText) event to modify group row text.
4. _(Optional)_ Implement [GroupRowTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.GroupRowTemplate) to display custom group row content.
