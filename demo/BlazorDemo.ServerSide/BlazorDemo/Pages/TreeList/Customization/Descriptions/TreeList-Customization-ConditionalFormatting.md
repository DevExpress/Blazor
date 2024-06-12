Our DevExpress TreeList for Blazor allows you to customize the appearance of UI elements based on custom conditions. To introduce this capability in your next DevExpress-powered Blazor app, handle the TreeList's [CustomizeElement](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.CustomizeElement) event and use the following event [arguments](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TreeListCustomizeElementEventArgs) to modify row and cell styles:

* [ElementType](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TreeListCustomizeElementEventArgs.ElementType) — An [element type](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TreeListElementType).
* [CssClass](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TreeListCustomizeElementEventArgs.CssClass) — The name of a CSS class applied to the processed element.
* [Attributes](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TreeListCustomizeElementEventArgs.Attributes) — Standard HTML attributes applied to the processed element.
* [Style](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TreeListCustomizeElementEventArgs.Style) — A standard HTML style attribute applied to the processed element.
* [VisibleIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TreeListCustomizeElementEventArgs.VisibleIndex) — The visible index of the processed row or row that contains the processed cell.
* [Column](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TreeListCustomizeElementEventArgs.Column) — The column that corresponds to the processed cell.
* [TreeList](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TreeListCustomizeElementEventArgs.TreeList) — Provides access to TreeList properties.

This demo customizes the appearance of TreeList elements as follows:

* Nodes with children are gray.
* Cells in **March Change** and **September Change** columns with values larger than 5% are colored green.
* Cells in **March Change** and **September Change** columns with values less than -5%  are colored red.
