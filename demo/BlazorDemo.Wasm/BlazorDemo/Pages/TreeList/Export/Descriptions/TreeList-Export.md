The DevExpress Blazor [TreeList](https://docs.devexpress.com/Blazor/404942/components/treelist) UI component allows you to export data to XLS, XLSX, CSV, and PDF files via the following data export methods:

* [ExportToXlsAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ExportToXlsAsync.overloads) — Exports data to the XLS format.
* [ExportToXlsxAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ExportToXlsxAsync.overloads) — Exports data to the XLSX format.
* [ExportToCsvAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ExportToCsvAsync.overloads) — Exports data to the CSV format.
* [ExportToPdfAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ExportToPdfAsync.overloads) — Exports data to PDF.

To customize the exported document, use the export method's `options` parameter.

This demo calls an export method once you click the desired "Export..." button. When exporting to XLSX/XLS/PDF, the `CustomizeCell` event handler italicizes values stored in the **Type** column. During PDF export operations, the [CustomizePageFooter](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TreeListDocumentExportOptions.CustomizePageFooter) event handler adds page numbers to the footer.

**Note**: By default, the DevExpress Blazor TreeList exports data from all visible columns. To exclude a column from export operations, set the column's [ExportEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListDataColumn.ExportEnabled) property to `false`.
