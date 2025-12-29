The DevExpress Blazor [Grid](https://docs.devexpress.com/Blazor/403143/grid) allows you to export data to XLS, XLSX, PDF, and CSV formats via the following data export methods:

* [ExportToXlsAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ExportToXlsAsync.overloads) — Exports data to XLS
* [ExportToXlsxAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ExportToXlsxAsync.overloads) — Exports data to XLSX
* [ExportToCsvAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ExportToCsvAsync.overloads) — Exports data to CSV
* [ExportToPdfAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ExportToPdfAsync.overloads) — Exports data to PDF

This demo calls an export method once you click the "Export..." button. The `options` parameter allows you to customize the exported document:

- The `CustomizeCell` event handler italicizes values in the **Contact Name** column.
- The `CustomizePageFooter` event handler adds page numbers to the page footer of PDF documents.
- When the **Export Selected Rows Only** checkbox (above the Grid component) is checked, our Blazor Grid exports selected records and corresponding group rows (`SelectedRowsExportMode` is set to `KeepGrouping`).

**Note**: Our Blazor Grid exports data from all visible columns. To exclude a column from export operations, set the column's [ExportEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.ExportEnabled) property to `false`.
