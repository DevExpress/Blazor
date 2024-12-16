Our New Item Row allows users to add data rows to the DevExpress Blazor Grid component. To display this row, set the [EditNewItemRow](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditNewRowPosition) property to one of the following values:

* `FixedOnTop` — The Grid displays the new item row above data records and keeps it visible during vertical scrolling and paging operations.
* `LastRow` — The Grid displays the new item row after the last data record.

Use the combo box in the Grid toolbar to change the New Item Row's position.

In [EditCell](https://docs.devexpress.com/Blazor/404756/components/grid/editing-and-validation/edit-modes/edit-cell) mode, users can press Tab or Shift+Tab keys to navigate between data cells in the New Item Row. When leaving the last/first cell, focus moves back to this row's first/last data cell, and the Grid validates row values. Based on validation results, the component performs one of the following actions:

* If validation fails, the component displays error icons.
* If validation succeeds, the component saves changes and starts editing a new row.

In this demo, validation is disabled. Once focus leaves the New Item Row, the Grid adds the row to the data source.
