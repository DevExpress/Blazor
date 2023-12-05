This demo illustrates how to implement batch data editing using our Blazor Grid's [EditCell](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditMode#edit-cell-ctp) mode. Batch data editing allows users to accumulate changes in memory and post them to the database when desired.

When you create a new row or modify/delete an existing row in this demo, all changes are stored in memory. You can press **Save** to apply all changes from memory (batch editing) to the underlying data source or press **Cancel** to discard accumulated changes.

The [CustomizeElement](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomizeElement) event allows you to highlight modified cells as needs dictate. You can also check whether a cell has unsaved changes and apply a custom CSS class within the event's handler.
