The Blazor [Grid](https://docs.devexpress.com/Blazor/403143/grid) allows you to use templates to customize column content and appearance: 

* [DxGridDataColumn.CellDisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.CellDisplayTemplate) — Specifies a cell template for an individual column.
* [DxGrid.DataColumnCellDisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.DataColumnCellDisplayTemplate) — Specifies a cell template for all columns.
* [DxGridDataColumn.HeaderCaptionTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridColumn.HeaderCaptionTemplate) — Specifies a header caption template for an individual column.
* [DxGrid.ColumnHeaderCaptionTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ColumnHeaderCaptionTemplate) — Specifies a header caption template for all columns.

The templates implement the `context` parameter that allows you to access Grid data and the Grid, including its rich API.

This demo customizes the **EmployeeId** column appearance and content. The column shows **More Info** links. Users can click these links to view details about data rows in a pop-up window. A tooltip is displayed when users hover the mouse pointer over the column caption.
