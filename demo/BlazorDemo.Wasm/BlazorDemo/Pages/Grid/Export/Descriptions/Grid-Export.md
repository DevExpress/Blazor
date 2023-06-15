The DevExpress Blazor [Grid](https://docs.devexpress.com/Blazor/403143/grid) allows you to export data to XLS, XLSX, and CSV file formats. When exporting to Excel formats, the resulting file can maintain data grouping, sorting, filtering, totals, and group summaries.

The Grid implements the following data export methods:

* [ExportToXlsAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ExportToXlsAsync.overloads) — Exports data in XLS format.
* [ExportToXlsxAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ExportToXlsxAsync.overloads) — Exports data in XLSX format.
* [ExportToCsvAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ExportToCsvAsync.overloads) — Exports data in CSV format.

All these methods accept the [options](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridXlExportOptions) parameter. This options parameter allows you to customize the exported document. 

The Grid exports data for every visible column. Set a column's [ExportEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.ExportEnabled) property to `false` to prevent data export for a specific column.

In this demo, export methods are called when a user clicks a corresponding "Export..." button. These methods accept the following settings:
* The [ExportSelectedRowsOnly](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridExportOptions.ExportSelectedRowsOnly) option is set based on the **Export Selected Rows Only** check box selection state.
* The [CustomizeCell](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridExportOptions.CustomizeCell) event handler applies italic formatting to cells within the **ContactName** column.

For detailed information on how to export grid data and examples, refer to the following help topic: [Export Data](https://docs.devexpress.com/Blazor/404338/components/grid/export).
