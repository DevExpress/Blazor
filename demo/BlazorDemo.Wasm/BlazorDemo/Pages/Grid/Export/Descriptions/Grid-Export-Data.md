The DevExpress Blazor [Grid](https://docs.devexpress.com/Blazor/403143/grid) UI component allows you to export data to XLS, XLSX, PDF, and CSV formats via the following data export methods:

* [ExportToXlsAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ExportToXlsAsync.overloads) — Exports data to the XLS format.
* [ExportToXlsxAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ExportToXlsxAsync.overloads) — Exports data to the XLSX format.
* [ExportToCsvAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ExportToCsvAsync.overloads) — Exports data to the CSV format.
* [ExportToPdfAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ExportToPdfAsync.overloads) — Exports data to PDF.

To customize the exported document, use the export method's `options` parameter.

This demo calls an export method once you click the desired "Export..." button. The **Export Selected Rows Only** checkbox above the Blazor Grid component sets the [ExportSelectedRowsOnly](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridExportOptions.ExportSelectedRowsOnly) option. When exporting to XLSX/XLS/PDF, the `CustomizeCell` event handler italicizes values stored in the **Contact Name** column. During PDF export operations, the [CustomizePageFooter](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridDocumentExportOptions.CustomizePageFooter) event handler adds page numbers to the footer.

**Note**: Our Blazor Grid exports data from all visible columns. To exclude a column from export operations, set the column's [ExportEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.ExportEnabled) property to `false`.
