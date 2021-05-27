The Blazor [Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid) allows users to sort its data.  

* To apply sorting for one column, users can click the column header. Repeating this action will change the sort order again. The sort glyph indicates the column's current sort order.  
* To sort the Grid against multiple columns, users should click column headers with the *Shift* key pressed.  
* To clear sorting, users can hold the *Ctrl* key and click the column headers. 

You can disable sorting for users: set the [DxGrid.AllowSort](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.AllowSort) or [DxGridColumn.AllowSort](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridColumn.AllowSort) property to `false` (applied to the entire Grid or an individual column). 

Use the following API members to sort data in code. 

* [DxGrid.ClearSort](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ClearSort) - Clears sorting. 
* [DxGrid.SortBy](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SortBy) - Sorts Grid data by a specified column. 
* [DxGridColumn.SortIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SortIndex) - Specifies a column's position among sorted columns. If the property is set to `-1`, grid data is not sorted by this column. 
* [DxGridColumn.SortOrder](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SortOrder) - Specifies a column's sort order (ascending or descending). 
* [DxGridColumn.SortMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SortMode) - Specifies how Grid data are sorted (by value, by display text, or custom logic is used)
