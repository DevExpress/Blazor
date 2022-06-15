The [Data Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1) allows users to add, edit, and remove data rows.

1.  Add [DxDataGridCommandColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridCommandColumn) to the Data Grid. This column displays the **New**, **Edit**, and **Delete** command buttons. To hide unnecessary buttons, use the [NewButtonVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridCommandColumn.NewButtonVisible), [EditButtonVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridCommandColumn.EditButtonVisible), and [DeleteButtonVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridCommandColumn.DeleteButtonVisible) properties.
2.  Handle the following events to post changes to an underlying data source:
    *   [RowInserting](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.RowInserting)/[RowInsertingAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.RowInsertingAsync) - Fires when a user adds a new row.
    *   [RowUpdating](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.RowUpdating)/[RowUpdatingAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.RowUpdatingAsync) - Fires when a user updates a data row.
    *   [RowRemoving](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.RowRemoving)/[RowRemovingAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.RowRemovingAsync) - Fires when a user deletes a data row.
3.  Handle the [InitNewRow](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.InitNewRow) event to initialize new data rows.
4.  Specify the [key data field](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.KeyFieldName) to enable the Data Grid to identify individual data items.

The Data Grid supports different edit modes. Use the **Edit Mode** option above (corresponds to the [EditMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.EditMode) property) to switch between available modes.

*   [DataGridEditMode.EditForm](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DataGridEditMode) (Default) - The Data Grid displays the edit form instead of the edited row.
*   [DataGridEditMode.PopupEditForm](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DataGridEditMode) - The Data Grid displays the edit form in a pop-up window.

When a user clicks **New** or **Edit**, the Data Grid displays the Edit Form. This form consists of data editors for each visible column. The editor type depends on the corresponding column's type.
