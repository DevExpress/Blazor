The DevExpress Blazor [Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid) allows users to sort data as requirements dictate. Sort operations can be applied via the Blazor Grid's UI elements as follows:

* To sort against a single column, users can click the appropriate column header. Repeating this action will change sort order. The sort glyph indicates the column's current sort order.
* To sort the Blazor Grid against multiple columns, users must click column headers with the *Shift* key pressed.
* To clear sort operations for a column, users must click the appropriate column header with the the *Ctrl* key pressed.

To disable sort operations, set the [DxGrid.AllowSort](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.AllowSort) or [DxGridDataColumn.AllowSort](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.AllowSort) property to `false` (applied to the entire Grid or to an individual column).

Use the following API members to sort Blazor Grid data in code: 

* [DxGrid.ClearSort](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ClearSort) - Clears sort operations.
* [DxGrid.SortBy](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SortBy.overloads) - Sorts Grid data against a specified column. 
* [DxGridDataColumn.SortIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.SortIndex) - Specifies a column's position among sorted columns. If the property is set to `-1`, grid data is not sorted by this column. 
* [DxGridDataColumn.SortOrder](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.SortOrder) - Specifies a column's sort order (ascending or descending). 
* [DxGridDataColumn.SortMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.SortMode) - Specifies how Grid data is sorted (by value, by display text, or custom logic is used)
