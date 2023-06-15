Users can click a column header to sort the Data Grid by this column. They can click the header again to change the sort order. The sort glyph indicates the column's current sort order. To sort the Data Grid against multiple columns, users should click column headers with the **Shift** key pressed. To clear sorting, users can hold the **Ctrl** key and click the column headers.

Set the [DxDataGrid.AllowSort](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.AllowSort) property to **false** to disable sorting in the entire Data Grid. Use a column's [AllowSort](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridColumn.AllowSort) property to enable/disable sorting by individual columns.

Use the following column properties to sort data in code:

*   [SortOrder](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridColumn.SortOrder) — Specifies a column's sort order.
*   [SortIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridColumn.SortIndex) — Specifies a column's position among sorted columns.

In this demo, values in the **ID** column cannot be sorted. The sort order for the **Country** and **City** columns are specified in the Data Grid's markup (see the code above).
