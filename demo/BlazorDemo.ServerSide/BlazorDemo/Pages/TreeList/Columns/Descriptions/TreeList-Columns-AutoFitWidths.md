Call the [AutoFitColumnWidths](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.AutoFitColumnWidths) method to resize columns based on content.

This method takes header, data cell, and summary value content into account. The auto fit algorithm uses the same units as the column's [Width](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListColumn.Width) property value. 

- If a column's width is set in pixels, the final width is in pixels. The column's width fits its content. 
- If a column's width is set in percentages or not set, the final width is in percentages. Columns may shrink or grow depending on the available space. 

Depending on calculated values, the following outcomes are possible:

* Columns occupy the entire width of the component. Example: all or several widths are in percentages.
* A scroll bar appears. Example: all widths are in pixels and the content is too wide.
* Empty space remains. Example: all widths are in pixels and the content is not wide enough.

In this demo, **Task**, **Assigned To**, and **Progress** column widths are in pixels, and their content is always fully visible. Other column widths are not specified – as such, these columns may shrink (to the limit set by [MinWidth](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListColumn.MinWidth)).
