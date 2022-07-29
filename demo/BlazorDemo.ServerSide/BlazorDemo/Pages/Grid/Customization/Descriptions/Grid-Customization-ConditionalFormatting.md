Our DevExpress [Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid) for Blazor allows you to customize the appearance of UI elements based on custom conditions. To do so, handle the Grid's [CustomizeElement](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomizeElement) event and use the following event [arguments](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridCustomizeElementEventArgs) to modify row and cell styles:

* [ElementType](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridCustomizeElementEventArgs.ElementType) - An [element type](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridElementType).
* [CssClass](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridCustomizeElementEventArgs.CssClass) - The name of a CSS class applied to a grid element.
* [Attributes](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridCustomizeElementEventArgs.Attributes) - Standard HTML attributes applied to a grid element.
* [Style](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridCustomizeElementEventArgs.Style) - A standard HTML style attribute applied to a grid element.
* [VisibleIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridCustomizeElementEventArgs.VisibleIndex) - The visible index of the processed row or row that contains the processed cell.
* [Column](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridCustomizeElementEventArgs.Column)- The column that corresponds to the processed cell or group row.
* [Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridCustomizeElementEventArgs.Grid) - Provides access to grid properties.

This demo customizes appearance of grid elements in the following way:  

* Data rows with **Total > 1000** are highlighted.
* All **Total** values are bold.
* If the grid rows are grouped by **Country**, the group row's tooltip displays group summary values.
