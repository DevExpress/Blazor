Our DevExpress Grid for Blazor allows you to color grid cells and rows according to their values. To do so, handle the Grid’s [CustomizeElement](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomizeElement) event and use the following event [arguments](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridCustomizeElementEventArgs) to modify row and cell styles:

* **ElementType** – An element type (a data row, group row or cell).
* **CssClass** - The name of a CSS class applied to a grid element.
* **Attributes** - Standard HTML attributes applied to a grid element.
* **Style** - A standard HTML style attribute applied to a grid element.
* **VisibleIndex** - The visible index of the processed row or row that contains the processed cell.
* **Column**- The column that corresponds to the processed cell or group row.
* **Grid** – Provides access to grid properties.

This demo customizes appearance of grid elements in the following way:  

* Data rows with **Total > 1000** are highlighted.
* All **Total** values are bold.
* If the grid rows are grouped by **Country**, the group row’s tooltip displays group summary values.
