In `EditCell` mode, the DevExpress Blazor TreeList displays an in-place editor when a user clicks a data cell. Users can then edit the current cell value and activate editors for other cells within the same row. When focus moves to a different row, the control validates user input and saves changes.

To enable cell editing, you must:

1. Set the [EditMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.EditMode) property to `EditCell`.
2. Specify the [KeyFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.KeyFieldName) property. If not set, the TreeList uses standard [.NET value equality comparison](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/equality-comparisons) to identify data items.
3. Handle the [CustomizeEditModel](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.CustomizeEditModel) event to initialize an edit model for new data rows (set predefined cell values and link new nodes to their parent).
4. Handle the following events to make final data changes, check access permissions, post changes to the underlying data source, and reload TreeList data:
    * [EditModelSaving](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.EditModelSaving) — Fires when a user saves the edited row and validation passes.
    * [DataItemDeleting](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.DataItemDeleting) — Fires when a user confirms the delete operation in the delete confirmation dialog. To enable delete operations, proceed to step 5.
5. (Optional) Declare a [DxTreeListCommandColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListCommandColumn) object in the [Columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.Columns) template to create and delete data rows. In addition to predefined **New** and **Delete** buttons, this column displays **Edit**, **Save**, and **Cancel** command buttons that are not used in `EditCell` mode. Disable [EditButtonVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListCommandColumn.EditButtonVisible), [CancelButtonVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListCommandColumn.CancelButtonVisible), and [SaveButtonVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListCommandColumn.SaveButtonVisible) properties to hide these buttons.

To display an editor in a data cell, users can focus the cell and press Enter. When the editor is visible, the following keyboard shortcuts are available:

* Enter — Validates the cell value and hides the editor.
* Esc — Hides the editor and discards changes made in this cell. Pressing Esc when the editor is hidden discards all changes made in the row and cancels row editing.
* Tab/Shift+Tab — Hides the editor, focuses the next/previous data cell, and displays an editor in the newly focused cell.
