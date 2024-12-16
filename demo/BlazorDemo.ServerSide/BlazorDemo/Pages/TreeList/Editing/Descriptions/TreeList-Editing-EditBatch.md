This demo highlights batch data editing operations using our Blazor TreeList's [EditCell](https://docs.devexpress.com/Blazor/405166/components/treelist/editing-and-validation/edit-modes/edit-cell) mode. Batch data editing allows users to accumulate changes in memory and post them to the database when desired.

When you create a new row or modify/delete an existing row in this demo, all changes are stored in memory. You can press **Submit** to apply all changes from memory (batch editing) to the underlying data source or press **Revert** to discard accumulated changes.

The [CustomizeElement](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.CustomizeElement) event handler highlights modified cells. The code checks whether a cell has unsaved changes and applies a custom CSS class.
