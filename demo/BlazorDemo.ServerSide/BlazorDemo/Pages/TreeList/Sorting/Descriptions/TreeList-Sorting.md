The DevExpress Blazor TreeList allows users to sort data as needs dictate. The following user-driven operations are available:

* Click a column header to sort data against one column. Subsequent clicks reverse sort order. A sort glyph indicates the column's current sort order (ascending or descending).
* Shift+click column headers to sort data against multiple columns.
* Ctrl+click a column header to clear sort operations against this column.
* Focus a column header with a keyboard and press Space, Shift+Space, or Ctrl+Space to change sort criteria.

To disable sort operations, set the [DxTreeList.AllowSort](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.AllowSort) or [DxTreeListDataColumn.AllowSort](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListDataColumn.AllowSort) property to `false` (applied to all TreeList columns or to an individual column).

Use the following API members to sort Blazor TreeList data in code: 

* [DxTreeList.ClearSort](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ClearSort) — Clears sort operations.
* [DxTreeList.SortBy](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.SortBy.overloads) — Sorts TreeList data against the specified column. 
* [DxTreeListDataColumn.SortIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListDataColumn.SortIndex) — Specifies the column's position among sorted columns. If the property is set to `-1`, TreeList data is not sorted against this column. 
* [DxTreeListDataColumn.SortOrder](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListDataColumn.SortOrder) — Specifies column sort order (ascending or descending). 
* [DxTreeListDataColumn.SortMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListDataColumn.SortMode) — Specifies whether to use custom logic to sort column data.
