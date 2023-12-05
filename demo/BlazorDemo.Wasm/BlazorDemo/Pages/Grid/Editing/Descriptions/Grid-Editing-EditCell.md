When `EditCell` mode is used, the DevExpress Blazor Grid displays an in-place editor when a user clicks a data cell. With the in-place editor, users can edit the current cell value and activate editors for other cells within the same row. When focus moves to a different row, the control validates user input and saves changes.

To enable cell editing, you must:

1. Enable the [KeyboardNavigationEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.KeyboardNavigationEnabled) property and set the [EditMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditMode) property to `EditCell`.
2. If your data object has a primary key, assign it to the [KeyFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.KeyFieldName) or [KeyFieldNames](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.KeyFieldNames) property. The Grid uses field values to compare and identify data items. If you do not specify these properties, the Grid uses standard [.NET value equality comparison](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/equality-comparisons) to identify data items.
3. Handle the following events to make final data changes, check access permissions, post changes to the underlying data source, and reload Grid data:
    * [EditModelSaving](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditModelSaving) — Fires when a user saves the edited row and validation passes.
    * [DataItemDeleting](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.DataItemDeleting) — Fires when a user confirms the delete operation in the delete confirmation dialog. To enable the delete operation, implement step 4.
4. (Optional) Declare a [DxGridCommandColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn) object in the [Columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.Columns) template to allow users to create and delete data rows. In addition to predefined **New** and **Delete** buttons, this column displays **Edit**, **Save**, and **Cancel** command buttons that are not used in this mode. Disable [EditButtonVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn.EditButtonVisible), [CancelButtonVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn.CancelButtonVisible), and [SaveButtonVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn.SaveButtonVisible) properties to hide these buttons.
5. (Optional) Handle the [CustomizeEditModel](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomizeEditModel) event to initialize an edit model for new data rows.

To display an editor in a data cell, users can focus the cell and press Enter. When the editor is visible, the following keyboard shortcuts are available:

* Enter — Validates the cell value and hides the editor.
* Esc — Hides the editor and discards changes made in this cell. Pressing Esc when the editor is hidden discards all changes made in the row and cancels row editing.
* Tab/Shift+Tab — Hides the editor, focuses the next/previous data cell, and displays an editor in the newly focused cell.

For detailed information on how to enable data editing and use edit-related options, refer to the following help topic: [Edit Data](https://docs.devexpress.com/Blazor/403454/components/grid/edit-data).
