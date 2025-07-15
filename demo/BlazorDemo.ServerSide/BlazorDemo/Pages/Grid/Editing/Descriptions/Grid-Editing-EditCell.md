When `EditCell` mode is used, the DevExpress Blazor Grid displays an in-place editor when a user clicks a data cell. This allows users to edit the current cell value and activate editors for other cells within the same row. When focus moves to a different row, the control validates user input and saves changes.

To enable cell editing:

1. Set the [EditMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditMode) property to `EditCell`.
2. If your data object has a primary key, assign it to the [KeyFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.KeyFieldName) or [KeyFieldNames](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.KeyFieldNames) property. The Grid uses field values to compare and identify data items. If you do not specify these properties, the Grid uses standard [.NET value equality comparison](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/equality-comparisons) to identify data items.
3. Handle the following events to make final data changes, check access permissions, post changes to the underlying data source, and reload Grid data:
    - [EditModelSaving](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditModelSaving) — Fires when a user saves the edited row and validation passes.
    - [DataItemDeleting](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.DataItemDeleting) — Fires when a user confirms the delete operation in the delete confirmation dialog. To enable the delete operation, implement step 4.
4. (Optional) Declare a [DxGridCommandColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn) object in the [Columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.Columns) template to allow users to create and delete data rows. In addition to predefined **New** and **Delete** buttons, this column displays **Edit**, **Save**, and **Cancel** command buttons that are not used in this mode. Disable [EditButtonVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn.EditButtonVisible), [CancelButtonVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn.CancelButtonVisible), and [SaveButtonVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn.SaveButtonVisible) properties to hide these buttons.
5. (Optional) Handle the [CustomizeEditModel](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomizeEditModel) event to initialize an edit model for new data rows.

The Grid control supports [keyboard shortcuts](https://docs.devexpress.com/Blazor/404652/components/grid/keyboard-support) that speed up navigation and editing. This demo showcases some of the most common shortcuts:

**Enter / Shift+Enter**

Opens an in-place editor for the focused cell (if not already open).

If an in-place editor is open, changes are applied, and the editor is closed. Focus can then move to the next/previous cell depending on the [EnterKeyDirection](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EnterKeyDirection) property. Select a value from the **Focus Moves on Enter** box to see how behavior changes:

- **No** (`GridEnterKeyDirection.None`): Validate the cell value and close the editor.
- **Up/Down** (`GridEnterKeyDirection.Column`): Move focus to the cell below/above (in the same column).
- **Left/Right** (`GridEnterKeyDirection.Row`): Move focus to the next/previous cell in the same row.

**Note:** <kbd>Shift</kbd>+<kbd>Enter</kbd> moves focus in the opposite direction.

**Esc**

Hides the in-place editor and discards changes made in that cell.

If the in-place editor is hidden, discards all changes made in the row and cancels row editing.

**Tab / Shift+Tab**

Hides the editor, focuses the next/previous data cell, and displays an editor in the newly focused cell.

**Start typing in a focused cell**

When the [EditOnKeyPress](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditOnKeyPress) property is enabled, users can start editing a cell by typing a value within it. The editor opens automatically and accepts entered characters.

Select the **Edit On Key Press** option to try it out.

For additional information on how you can enable data editing and use edit-related options, refer to the following [help topic](https://docs.devexpress.com/Blazor/404756/components/grid/editing-and-validation/edit-modes/edit-cell).
