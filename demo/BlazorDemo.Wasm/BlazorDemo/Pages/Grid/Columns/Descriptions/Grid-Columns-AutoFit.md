Call the [AutoFitColumnWidths](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.AutoFitColumnWidths) method to match column width values to actual content.

This method takes header, data cell, and summary value content into account. The auto fit algorithm uses the same units as the column's [Width](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridColumn.Width) property value. 

- If a column's width is set in pixels, the final width is in pixels. The column's width fits its content. 
- If a column's widths is set in percentages or not set, the final width is in percentages. Columns may shrink or grow based on available space. 

Depending on calculated values, the following outcomes are possible:

* Columns occupy the entire width of the component. Example: all or several widths are in percentages.
* A scroll bar appears. Example: all widths are in pixels and the content is too wide.
* Empty space remains. Example: all widths are in pixels and the content is not wide enough.

In this demo, the **Company Name**, selection, and command columns have their width specified in pixels, and their content is always fully visible. The **Address** column's width is not specified, so it may narrow but not less than its [MinWidth](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridColumn.MinWidth) (120 pixels).
