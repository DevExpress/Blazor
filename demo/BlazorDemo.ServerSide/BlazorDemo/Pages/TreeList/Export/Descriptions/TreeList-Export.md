The DevExpress Blazor [TreeList](https://docs.devexpress.com/Blazor/404942/components/treelist) allows you to export data to XLS, XLSX, and CSV files via the following data export methods:

* [ExportToXlsAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ExportToXlsAsync.overloads) — Exports data in XLS format.
* [ExportToXlsxAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ExportToXlsxAsync.overloads) — Exports data in XLSX format.
* [ExportToCsvAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ExportToCsvAsync.overloads) — Exports data in CSV format.

All three file export methods accept the [options](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TreeListXlExportOptions) parameter. This parameter allows you to customize the exported document as requirements dictate. 

In this demo, export methods are called when a user clicks the **Export to XLSX/XLS or Export to CSV** button (when exporting to XLSX/XLS, the [CustomizeCell](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TreeListExportOptions.CustomizeCell) option is used to italicize values stored in the **Type** column). 

Note: Out Blazor TreeList exports data from all visible columns. To exclude a column from export operations, set the column's [ExportEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListDataColumn.ExportEnabled) property to `false`.
