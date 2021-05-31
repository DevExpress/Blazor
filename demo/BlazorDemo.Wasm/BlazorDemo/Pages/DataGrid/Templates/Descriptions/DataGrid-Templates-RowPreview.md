This demo illustrates how to use the Data Grid’s [RowPreviewTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.RowPreviewTemplate) property to show preview sections under each data row across all columns. These sections can display any content, such as tables, images, values from data source fields, custom text, and so on.

The template's **Context** parameter has the following properties:

*   [RowIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DataRowInfo-1.RowIndex) - Returns a zero-based row index.
*   [DataItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DataRowInfo-1.DataItem) - Returns a data item that corresponds to the row.

When you define the row preview template, use the [Columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.Columns) property to add Data Grid columns.
