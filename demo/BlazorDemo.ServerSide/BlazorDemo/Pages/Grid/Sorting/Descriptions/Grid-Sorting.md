The DevExpress Blazor [Grid](https://docs.devexpress.com/Blazor/403143/grid) allows users to sort data as requirements dictate. The following user operations are available:

* Click a column header to sort data against one column. Subsequent clicks reverse the sort order. The sort glyph indicates the column's current sort order (ascending or descending).
* Hold Shift and click column headers to sort data by multiple columns. 
* Hold Ctrl and click a column header to clear sorting by this column.

To disable sort operations, set the [DxGrid.AllowSort](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.AllowSort) or [DxGridDataColumn.AllowSort](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.AllowSort) property to `false` (applied to the entire Grid or to an individual column).

Use the following API members to sort Blazor Grid data in code: 

* [DxGrid.ClearSort](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ClearSort) — Clears sort operations.
* [DxGrid.SortBy](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SortBy.overloads) — Sorts Grid data against a specified column. 
* [DxGridDataColumn.SortIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.SortIndex) — Specifies a column's position among sorted columns. If the property is set to `-1`, grid data is not sorted by this column. 
* [DxGridDataColumn.SortOrder](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.SortOrder) — Specifies a column's sort order (ascending or descending). 
* [DxGridDataColumn.SortMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.SortMode) — Specifies how a column's data is sorted (by value, by display text, or custom logic is used)

In this demo, [keyboard navigation](https://docs.devexpress.com/Blazor/404652/components/grid/keyboard-support#header-row) is enabled. You can focus a column header with a keyboard and press Space, Shift+Space, or Ctlr+Space to change sort criteria.

For more information, refer to the following topic: [Sort Data](https://docs.devexpress.com/Blazor/404460/components/grid/sort-data).
