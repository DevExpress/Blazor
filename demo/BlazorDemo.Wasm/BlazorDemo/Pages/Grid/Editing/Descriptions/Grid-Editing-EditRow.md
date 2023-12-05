The DevExpress Blazor Grid allows users to edit its data in the inline edit row. The control automatically generates and configures cell editors for individual columns based on associated data types. To enable this functionality, follow the steps below:

1. Declare a [DxGridCommandColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn) object in the [Columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.Columns) template. This column displays predefined **New**, **Edit**, **Save**, **Cancel**, and **Delete** command buttons.
2. Set the [EditMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditMode) property to `EditRow`.
3. Handle the following events to make any final data changes, check access permissions, post changes to the underlying data source, and reload Grid data:
    * [EditModelSaving](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditModelSaving) — Fires when a user saves the edited row and validation passes.
    * [DataItemDeleting](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.DataItemDeleting) — Fires when a user confirms the delete operation in the delete confirmation dialog.
4. If your data object has a primary key, assign it to the [KeyFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.KeyFieldName) or [KeyFieldNames](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.KeyFieldNames) property. The Grid uses field values to compare and identify data items. If you do not specify these properties, the Grid uses the standard [.NET value equality comparison](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/equality-comparisons) to identify data items.
5. (Optional) Handle the [CustomizeEditModel](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomizeEditModel) event to initialize an edit model for new data rows.

For detailed information on how to enable data editing and use edit-related options, refer to the following help topic: [Edit Data](https://docs.devexpress.com/Blazor/403454/components/grid/edit-data).
