Our **New Item Row** allows users to add data rows to the DevExpress Blazor Grid component. Use the [EditNewRowPosition](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditNewRowPosition) property to specify visibility and location of the New Item Row:

* `Top` — The New Item Row is hidden. Once a user clicks the **New** button or you call the [StartEditNewRowAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.StartEditNewRowAsync(System.String)) method, the Grid displays an edit form, edit row, or cell editors *at the top of the current page*.
* `Bottom` — The New Item Row is hidden. Once a user clicks the **New** button or you call the [StartEditNewRowAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.StartEditNewRowAsync(System.String)) method, the Grid displays an edit form, edit row, or cell editors *at the bottom of the current page*.
* `FixedOnTop` — The Grid displays the New Item Row above data records and keeps it visible during vertical scrolling and paging operations.
* `LastRow` — The Grid displays the New Item Row after the last data record.

Use the combo box in the Grid's toolbar to specify the New Item Row's position: **Fixed On Top** or **Last Row**.

In [EditCell](https://docs.devexpress.com/Blazor/404756/components/grid/editing-and-validation/edit-modes/edit-cell) mode, users can press Tab/Shift+Tab keys to navigate between data cells in the New Item Row. When leaving the last/first cell, focus moves back to this row's first/last data cell, and the Grid validates row values as necessary. Based on validation results, the component executes one of the following actions:

* If validation fails, the component displays error icons.
* If validation passes, the component saves changes and starts editing a new row.

In this demo, validation is disabled. Once focus leaves the New Item Row, our Blazor Grid adds the row to the data source. The [EditOnKeyPress](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditOnKeyPress) property is enabled and row editing starts once you begin typing.
