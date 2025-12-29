The DevExpress Blazor [TreeList](https://docs.devexpress.com/Blazor/404942/components/treelist) allows you to export data to XLS, XLSX, PDF, and CSV formats via the following data export methods:

* [ExportToXlsAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ExportToXlsAsync.overloads) — Exports data to XLS
* [ExportToXlsxAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ExportToXlsxAsync.overloads) — Exports data to XLSX
* [ExportToCsvAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ExportToCsvAsync.overloads) — Exports data to CSV
* [ExportToPdfAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ExportToPdfAsync.overloads) — Exports data to PDF

This demo calls an export method once you click the "Export..." button. The `options` parameter allows you to customize the exported document:

- The `CustomizeCell` event handler italicizes values in the **Type** column.
- The `CustomizePageFooter` event handler adds page numbers to the page footer of PDF documents.
- When the **Export Selected Rows Only** checkbox (above the TreeList component) is checked, our Blazor TreeList exports selected records and their parents (`SelectedRowsExportMode` is set to `KeepHierarchy`).

**Note**: Our Blazor TreeList exports data from all visible columns. To exclude a column from export operations, set the column's [ExportEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListDataColumn.ExportEnabled) property to `false`.
