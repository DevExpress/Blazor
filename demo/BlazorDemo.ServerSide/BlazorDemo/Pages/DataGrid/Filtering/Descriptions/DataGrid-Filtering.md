Enable the [ShowFilterRow](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.ShowFilterRow) option to display a row that allows users to filter grid data. This row displays different in-place editors based on the column types. Users can filter data as follows:

*   [DxDataGridDateEditColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridDateEditColumn) (Order Date) - Select a date from the drop-down calendar or type a date in the editor and press Enter.
*   [DxDataGridComboBoxColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridComboBoxColumn-1) (Ship Country) - Select an item from the drop-down list or type text into an editor to filter its items on-the-fly.
*   [DxDataGridColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridColumn) (Product Name) - Type text in the editor and press Enter.
*   [DxDataGridSpinEditColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridSpinEditColumn) (Unit Price and Quantity) - Click spin buttons or type a value in the editor and press Enter.

Each editor contains a clear button that resets the filter by the corresponding column. Use [DxDataGridCommandColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridCommandColumn) to display the common clear button that resets the entire filter. You can also use the [AllowFilter](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridColumn.AllowFilter) property to prevent users from filtering data by individual columns.
