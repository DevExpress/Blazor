To enable data editing within the DevExpress Blazor Grid:

1. Declare a [DxGridCommandColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn) object in the [Columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.Columns) template. This column displays predefined **New**, **Edit**, and **Delete** command buttons. 
2. Use the [EditFormTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditFormTemplate) to define Grid edit form content. The edit form displays predefined **Save** and **Cancel** buttons.
3. Handle the following events to validate user input, access permissions, and post changes to an underlying data source:
    * [EditModelSaving](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditModelSaving) – Fires when a user submits the edit form and validation passes.
    * [DataItemDeleting](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.DataItemDeleting) – Fires when a user confirms the delete operation in the delete confirmation dialog.

    Note that Grid data must be reloaded once you save information to the data source.
4. If your data object has a primary key, assign it to the [KeyFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.KeyFieldName) or [KeyFieldNames](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.KeyFieldNames) property. The Grid uses field values to compare and identify data items. If you do not specify these properties, the Grid uses standard [.NET value equality comparison](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/equality-comparisons) to identify data items.
5. (Optional) Handle the [CustomizeEditModel](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomizeEditModel) event to initialize an edit model for new data rows. 

Our Blazor Grid supports different edit modes. Use the [Edit Mode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditMode) option above to switch between available modes.
* [GridEditMode.EditForm](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridEditMode) (Default) – The Grid displays the edit form instead of the edited row.
* [GridEditMode.PopupEditForm](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridEditMode) – The Grid displays the edit form in a pop-up window.

For detailed information on how to enable data editing and use edit-related option, refer to the following help topic: [Edit Data and Validate Input](https://docs.devexpress.com/Blazor/403454/grid/edit-data-and-validate-input).
