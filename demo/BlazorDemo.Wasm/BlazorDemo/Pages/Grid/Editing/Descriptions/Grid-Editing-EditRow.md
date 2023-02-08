The DevExpress Blazor Grid allows users to edit its data in the inline edit row. To enable this functionality, follow the steps below:

1. Declare a [DxGridCommandColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn) object in the [Columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.Columns) template. This column displays predefined New, Edit, Save, Cancel, and Delete command buttons.
2. Set the [EditMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditMode) property to `GridEditMode.EditRow`.
3. Specify the [CellEditTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.CellEditTemplate) for each column to define Grid edit row content.

    You can also specify the [DataColumnCellEditTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.DataColumnCellEditTemplate) to define a common template for Grid edit row cells (this technique is used in the [Edit Row Input Validation](Grid/EditData#EditRowValidation) demo).

4. Handle the following events to validate user input, access permissions, and post changes to an underlying data source:

    * [EditModelSaving](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditModelSaving) — Fires when a user saves the edited row and validation passes.
    * [DataItemDeleting](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.DataItemDeleting) — Fires when a user confirms the delete operation in the delete confirmation dialog.
    
    Note that Grid data must be reloaded once you save information to the data source.
5. If your data object has a primary key, assign it to the [KeyFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.KeyFieldName) or [KeyFieldNames](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.KeyFieldNames) property. The Grid uses field values to compare and identify data items. If you do not specify these properties, the Grid uses the standard [.NET value equality comparison](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/equality-comparisons) to identify data items.
6. (Optional) Handle the [CustomizeEditModel](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomizeEditModel) event to initialize an edit model for new data rows.

For more information on how to enable data editing and use edit-related options, refer to the following help topic: [Edit Data and Validate Input](https://docs.devexpress.com/Blazor/403454/grid/edit-data-and-validate-input).

This demo comes with an enabled Integrated [editor render mode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditorRenderMode). In this mode, the Grid renders editors in filter rows so that they occupy the entire cell; editor borders are not displayed.
