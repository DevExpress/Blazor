The DevExpress Blazor TreeList allows you to include column filter menus (drop-down lists used to filter column values) within your DevExpress-powered Blazor app.

To display column filter menu buttons across all data columns, set the [DxTreeList.FilterMenuButtonDisplayMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.FilterMenuButtonDisplayMode) property to `Always`. You can also use the [DxTreeListDataColumn.FilterMenuButtonDisplayMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListDataColumn.FilterMenuButtonDisplayMode) property to set button visibility for a specific data column.

A size grip in the corner of a filter menu allows users to resize the menu. 

You can use the following APIs to customize the filter menu as necessary:

* [CustomizeFilterMenu](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.CustomizeFilterMenu) event: fires before the drop-down filter is displayed on-screen and allows you to customize filter items.
* [FilterMenuTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListDataColumn.FilterMenuTemplate) property: specifies the dropdown menu template used within your Blazor app. In this demo, the **Progress** column's filter menu leverages this property. If your control displays **DateTime** and **DateTime?** columns, you can switch between a pre-defined [HierarchicalDateView](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TreeListDataColumnFilterMenuTemplateContext.HierarchicalDateView) and [ListView](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TreeListDataColumnFilterMenuTemplateContext.ListView) (available view the template's `context` parameter).
* The [DataColumnFilterMenuTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.DataColumnFilterMenuTemplate) property: specifies the template used for all TreeList dropdown filter menus.

Once you apply a filter to a column, all other TreeList column filter menus hide values that do not match the specified filter criteria. Hold down the Shift key and click a filter button to display all values.

**Accessibility-related**
You can focus a column header and press the Alt+Down Arrow or Shift+Alt+Down Arrow to open the TreeList column filter menu.

For additional information, refer to the following help topic: [Column Filter Menu](https://docs.devexpress.com/Blazor/405186/components/treelist/data-shaping/filter-data/filter-menu).
