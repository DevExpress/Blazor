When `EditCell` mode is used, the DevExpress Blazor TreeList displays an in-place editor when a user clicks a data cell. This allows users to edit the current cell value and activate editors for other cells within the same row. When focus moves to a different row, the control validates user input and saves changes.

To enable cell editing:

1. Set the [EditMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.EditMode) property to `EditCell`.
2. Specify the [KeyFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.KeyFieldName) property. If not set, the TreeList uses standard [.NET value equality comparison](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/equality-comparisons) to identify data items.
3. Handle the [CustomizeEditModel](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.CustomizeEditModel) event to initialize an edit model for new data rows (set predefined cell values and link new nodes to their parent).
4. Handle the following events to make final data changes, check access permissions, post changes to the underlying data source, and reload TreeList data:
    - [EditModelSaving](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.EditModelSaving) — Fires when a user saves the edited row and validation passes.
    - [DataItemDeleting](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.DataItemDeleting) — Fires when a user confirms the delete operation in the delete confirmation dialog. To enable delete operations, proceed to step 5.
5. (Optional) Declare a [DxTreeListCommandColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListCommandColumn) object in the [Columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.Columns) template to create and delete data rows. In addition to predefined **New** and **Delete** buttons, this column displays **Edit**, **Save**, and **Cancel** command buttons that are not used in `EditCell` mode. Disable [EditButtonVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListCommandColumn.EditButtonVisible), [CancelButtonVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListCommandColumn.CancelButtonVisible), and [SaveButtonVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListCommandColumn.SaveButtonVisible) properties to hide these buttons.

The TreeList control supports [keyboard shortcuts](https://docs.devexpress.com/Blazor/405207/components/treelist/keyboard-support) that speed up navigation and editing. This demo showcases some of the most common shortcuts:

**Enter / Shift+Enter**

Opens an in-place editor for the focused cell (if not already open).

If an in-place editor is open, changes are applied, and the editor is closed. Focus can then move to the next/previous cell depending on the [EnterKeyDirection](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.EnterKeyDirection) property. Select a value from the **Focus Moves on Enter** box to see how behavior changes:

- **No** (`TreeListEnterKeyDirection.None`): Validate the cell value and close the editor.
- **Up/Down** (`TreeListEnterKeyDirection.Column`): Move focus to the cell below/above (in the same column).
- **Left/Right** (`TreeListEnterKeyDirection.Row`): Move focus to the next/previous cell in the same row.

**Note:** <kbd>Shift</kbd>+<kbd>Enter</kbd> moves focus in the opposite direction.

**Esc**

Hides the in-place editor and discards changes made in that cell.

If the in-place editor is hidden, discards all changes made in the row and cancels row editing.

**Tab / Shift+Tab**

Hides the editor, focuses the next/previous data cell, and displays an editor in the newly focused cell.

**Start typing in a focused cell**

When the [EditOnKeyPress](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.EditOnKeyPress) property is enabled, users can start editing a cell by typing a value within it. The editor opens automatically and accepts entered characters.

Select the **Edit On Key Press** option to try it out.

For additional information on how you can enable data editing and use edit-related options, refer to the following [help topic](https://docs.devexpress.com/Blazor/405166/components/treelist/editing-and-validation/edit-modes/edit-cell).
