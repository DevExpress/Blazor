The DevExpress Blazor [Grid](https://docs.devexpress.com/Blazor/403143/grid) allows users to filter data as needs dictate. Enable the [ShowFilterRow](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ShowFilterRow) property to activate the integrated DevExpress Grid Filter Row (which displays in-place editors for all data columns). When a user enters a value into an editor, the Grid creates a filter condition based on the value and applies this condition to the corresponding column.

You can use the following column properties to customize filter row behavior: 
* [FilterRowOperatorType](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.FilterRowOperatorType) — Specifies an operator used to create a filter condition based on the filter row value. If you do not define this option, the Grid chooses the operator type automatically: `Contains` for columns bound to [string](https://docs.microsoft.com/en-us/dotnet/api/system.string) data types; `Equal` for all others.
* [FilterRowValue](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.FilterRowValue) — Specifies the initial value in the filter row editor. If you define this property, you should also specify the [FilterRowOperatorType](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.FilterRowOperatorType) property.
* [FilterRowEditorVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.FilterRowEditorVisible) — Specifies whether to display the filter row editor.

The Grid allows you to customize the filter row editors in the following ways:

* Declare and customize editor settings in a column's [EditSettings](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.EditSettings) property markup.
* Handle the [CustomizeFilterRowEditor](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomizeFilterRowEditor) event to modify editor settings at runtime.
* Create the [FilterRowCellTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.FilterRowCellTemplate) to implement a custom filter row cell content.

In this demo, the **Customer** column's settings are modified to display values from an external collection in the data rows and in the filter row. The [CustomizeFilterRowEditor](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomizeFilterRowEditor) event handler hides the **Clear** button for **Order Id** and **Order Date** columns; the [FilterRowCellTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.FilterRowCellTemplate) property implements the custom filter for the **Unit Price** column.

Our Blazor Grid also supports a command column with a Clear button that resets the filter. To display this column, declare a [DxGridCommandColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn) object in the [Columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.Columns) template.

To manage filter options in code, you can call the [FilterBy](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.FilterBy(System.String-DevExpress.Blazor.GridFilterRowOperatorType-System.Object)) and [ClearFilter](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ClearFilter) methods. 

This demo comes with an enabled Integrated [editor render mode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditorRenderMode). In this mode, the Grid renders editors in filter rows so that they occupy the entire cell; editor borders are not displayed.
