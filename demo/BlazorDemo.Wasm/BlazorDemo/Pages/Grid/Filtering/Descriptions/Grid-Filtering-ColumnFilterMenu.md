The DevExpress Blazor [Grid](https://docs.devexpress.com/Blazor/403143/grid)'s column filter menu displays a drop-down list of column values. A size grip in the corner of a filter menu allows users to modify menu width and height. Set the [DxGrid.FilterMenuButtonDisplayMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.FilterMenuButtonDisplayMode) property to `Always` to display filter menu buttons for each data column, or use the [DxGridDataColumn.FilterMenuButtonDisplayMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.FilterMenuButtonDisplayMode) property to control button visibility for a specific data column.

You can use the following API to customize the filter menu as requirements dictate:

* The [CustomizeFilterMenu](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomizeFilterMenu) event fires before the drop-down filter is displayed and allows you to customize filter items.
* The [FilterMenuTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.FilterMenuTemplate) property specifies the template used for the content displayed within the column's drop-down filter. You can switch between [hierarchical](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridDataColumnFilterMenuTemplateContext.HierarchicalDateView) and [list](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridDataColumnFilterMenuTemplateContext.ListView) views for **DateTime** and **DateTime?** Values in this template.
* The [DataColumnFilterMenuTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.DataColumnFilterMenuTemplate) property specifies the template used for all drop-down filter menus in the Grid.

Once you apply a filter to a column, other filter menus hide values that do not match the specified filter criteria. Hold down Shift and click a filter button to display all values. If [keyboard navigation](https://docs.devexpress.com/Blazor/404652/components/grid/keyboard-support) is enabled, you can focus a column header and press Alt+Arrow Down or Shift+Alt+Arrow Down to open the filter menu.

In this demo, the keyboard navigation feature is enabled and the filter menu for the **Total** column is "templated". Templates allow you to include custom filter options in your Blazor-powered web app.

For more information, refer to the following topic: [Column Filter Menu](https://docs.devexpress.com/Blazor/404417/components/grid/filter-data/filter-menu).
