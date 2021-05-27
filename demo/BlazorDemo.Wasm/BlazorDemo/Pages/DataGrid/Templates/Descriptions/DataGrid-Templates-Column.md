You can use the [DisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridColumn.DisplayTemplate) and [EditTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridColumn.EditTemplate) properties to specify custom content for the column and its editor. Use the template's **context** parameter to access a data object and its fields.

When you use an edit template, you should call the [CellEditContext.OnChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.CellEditContext.OnChanged.overloads) method to inform the Data Grid about changes and save new cell values to the [EditedValues](https://docs.devexpress.com/Blazor/DevExpress.Blazor.CellEditContext.EditedValues) collection. Then, pass this collection to the [RowInserting](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.RowInserting) and [RowUpdating](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.RowUpdating) events.

*   **Availability column** - The display template uses checkboxes and colored text to visualize column values. The edit template embeds a ComboBox into the edit form.

*   **Category column** - The display template builds a composite string and displays it in plain text. The edit template embeds another Data Grid to enable lookup functionality.

Review how values in the Availability and Category columns are formatted and try the Edit action to see the custom editors integrated into the edit form.
