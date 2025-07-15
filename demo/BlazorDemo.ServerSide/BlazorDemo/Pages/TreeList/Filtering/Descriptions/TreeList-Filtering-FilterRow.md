The DevExpress Blazor TreeList allows users to filter data as their needs dictate. Enable the [ShowFilterRow](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ShowFilterRow) property to activate the integrated DevExpress TreeList Filter Row (displays in-place editors for all data columns). When a user enters a value into an editor, the TreeList creates a filter condition based on the value and applies this condition to the corresponding column. The [FilterTreeMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.FilterTreeMode) property specifies whether the TreeList component displays child/parent records for rows that meet search criteria. Select the **Display Nodes** option to try different filter modes.

You can use the following column properties to customize filter row behavior: 
* [FilterRowOperatorType](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListDataColumn.FilterRowOperatorType) — Specifies an operator used to create a filter condition based on the filter row value. If you do not define this option, our Blazor TreeList chooses the operator type automatically: `Contains` for columns bound to [string](https://docs.microsoft.com/en-us/dotnet/api/system.string) data types; `Equal` for all others.
* [FilterRowValue](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListDataColumn.FilterRowValue) — Specifies the initial value in the filter row editor. If you define this property, you should also specify the [FilterRowOperatorType](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListDataColumn.FilterRowOperatorType) property.
* [FilterRowEditorVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListDataColumn.FilterRowEditorVisible) — Specifies whether to display the filter row editor.

The TreeList allows you to customize filter row editors in the following manner:

* Declare and customize editor settings in a column's [EditSettings](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListDataColumn.EditSettings) property markup.
* Handle the [CustomizeFilterRowEditor](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.CustomizeFilterRowEditor) event to modify editor settings at runtime.
* Create [FilterRowCellTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListDataColumn.FilterRowCellTemplate) to implement custom filter row cell content.

In this demo, settings for the **Assigned To** and **Priority** columns are modified to display values from external collections for the filter row/data rows. The [FilterRowCellTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListDataColumn.FilterRowCellTemplate) property implements the filter editor for the **Progress** column.
