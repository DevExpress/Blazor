The DevExpress Blazor [Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid) allows users to resize columns as needed. When users position the mouse pointer over the right border of a column, the component displays a double-sided arrow. This arrow allows users to drag the column border and change column width. To specify whether and how users can resize Grid columns, set the [ColumnResizeMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ColumnResizeMode) property to one of the following values:

* [GridColumnResizeMode.Disabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridColumnResizeMode) - A user cannot resize columns.
* [GridColumnResizeMode.NextColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridColumnResizeMode) - When a user resizes a column, the width of the column to the right changes, but the Grid's total width does not change.
* [GridColumnResizeMode.ColumnsContainer](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridColumnResizeMode) -  When a user resizes a column, all other columns retain width settings, but the width of the entire column container changes proportionally.

Use the **Column Resize Mode** combobox to switch between different modes.
