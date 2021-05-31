This module illustrates [cascade comboboxes](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2#cascading-comboboxes): **City** and **Region**. These comboboxes are displayed when you edit a grid row. The **City** combobox is dynamically populated with city names based on the value selected in the **Region** combobox.

Both the Region and City columns use the [EditTemplate context](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridColumn.EditTemplate) cast to the [CellEditContext](https://docs.devexpress.com/Blazor/DevExpress.Blazor.CellEditContext) type that contains:

*   An original cell value as a **DataItem** object.
*   An [EditedValues](https://docs.devexpress.com/Blazor/DevExpress.Blazor.CellEditContext.EditedValues) dictionary with changed cell values.
*   A [CellValue](https://docs.devexpress.com/Blazor/DevExpress.Blazor.CellEditContext.CellValue) object that stores the current cell’s value.
*   Two overloads of the [OnChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.CellEditContext.OnChanged(System.Object)) method that allow one combobox to respond to another combobox’s value change.
*   The [GetEditorValue](https://docs.devexpress.com/Blazor/DevExpress.Blazor.CellEditContext.GetEditorValue(System.String)) method that returns a value of any grid cell.

Click **Edit** to see how the **Region** and **City** comboboxes communicate using the [OnChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.CellEditContext.OnChanged(System.Object)) and [GetEditorValue](https://docs.devexpress.com/Blazor/DevExpress.Blazor.CellEditContext.GetEditorValue(System.String)) methods to pass/get values to/from each other.
