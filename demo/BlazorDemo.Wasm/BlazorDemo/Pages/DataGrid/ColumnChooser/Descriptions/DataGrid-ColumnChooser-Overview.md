The Column Chooser is a separate window that allows users to show, hide, and reorder Data Grid columns at runtime. The Column Chooser window displays a list of all data column headers (both visible and hidden). Use the Column Chooser window to:

*   Change column visibility. To show or hide a column, use the checkbox next to the column header.
*   Reorder columns. To change column position within the grid, use the drag icon next to the column header to drag and drop it to a new position.

To display the Column Chooser in the Data Grid’s toolbar, follow the steps below:

1.  Add [HeaderTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.HeaderTemplate) to the Data Grid’s markup.
2.  Add the [DxDataGridColumnChooserToolbarItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridColumnChooserToolbarItem) item to the [Toolbar](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbar) component in this template. Note that **DxDataGridColumnChooserToolbarItem** buttons are only used for toolbars defined in the Data Grid component.

In this demo, the **Birth Date**, **File Name**, **Title**, and **Notes** columns are hidden. Use the Column Chooser to display these columns and reorder visible columns.
