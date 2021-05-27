HTML decoration allows you to color data grid cells, rows and columns according to their values.  
The [Data Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1) includes the [HtmlRowDecoration](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.HtmlRowDecoration) and [HtmlDataCellDecoration](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.HtmlDataCellDecoration) events that highlight grid rows and cells via the following arguments:

*   **CssClass** - A name of a CSS class applied to a grid element.
*   **Attributes** - Standard HTML attributes applied to a grid element.
*   **Style** - A standard HTML style attribute applied to a grid element.

Events also have arguments that depend on a target grid element (a row or a cell). The most commonly-used arguments are:

*   **DataItem** - A data source item that corresponds to the processed row or a row that contains the processed cell.
*   **VisibleIndex**, **RowVisibleIndex** - The visible index of the processed row or of a row that contains the processed cell, respectively.
*   **Field** - A name of a data source field that supplies data for a column. This argument is used for cells only.
