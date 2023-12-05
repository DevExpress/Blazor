Call the [AutoFitColumnWidths](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.AutoFitColumnWidths(System.Boolean)) method to match column width values to actual content.

This method takes header, data cell, and summary value content into account. Subsequent column width values can be in pixels or percentages, and depending on calculated values, the following may occur:

* Columns occupy the entire width of the component.
* A scroll bar appears.
* Columns occupy less space than allocated component width.

Users can also double-click a column's right edge to apply an optimal width at runtime.
