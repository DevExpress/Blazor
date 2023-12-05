The DevExpress Blazor [Grid](https://docs.devexpress.com/Blazor/403143/grid) allows users to resize columns. When a user position the mouse pointer over the right edge of a column, the cursor becomes a double-sided arrow. The grid controls indicate that the user can drag the column edge and change the column width. Users can also double-click a column's right border to apply the optimal width.

To specify whether and how users can resize Grid columns, set the [ColumnResizeMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ColumnResizeMode) property to one of the following values:

* `Disabled` — A user cannot resize columns.
* `NextColumn` — When a user resizes a column, the width of the column to the right changes, but the Grid's total width does not change.
* `ColumnsContainer` — When a user resizes a column, all other columns retain width settings, but the width of the entire column container changes proportionally.

Use the **Column Resize Mode** combobox to switch between different modes.
