The DevExpress Blazor [Grid](https://docs.devexpress.com/Blazor/403143/grid)'s column filter menu displays a dropdown list of all unique values within a column. A size grip in the corner of a filter menu allows users to change the menu's width and height. Set the [DxGrid.FilterMenuButtonDisplayMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.FilterMenuButtonDisplayMode) property to `Always` to display filter menu buttons for each data column, or use the [DxGridDataColumn.FilterMenuButtonDisplayMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.FilterMenuButtonDisplayMode) property to control button visibility for a specific data column.

You can use the following API to customize the filter menu as requirements dictate:

* The [CustomizeFilterMenu](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomizeFilterMenu) event fires before the filter dropdown is displayed and allows you to customize filter items.
* The [FilterMenuTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.FilterMenuTemplate) property specifies the template used for the content displayed within the column filter dropdown.
* The [DataColumnFilterMenuTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.DataColumnFilterMenuTemplate) property specifies the common template used to display all filter menu dropdowns in the Grid.

In this demo, the filter menus for **Order Date** and **Total** columns are "templated". By using templates, our Grid allows you to introduce custom filter options to your Blazor-powered web app.

For more information, refer to the following topic: [Column Filter Menu](https://docs.devexpress.com/Blazor/404417/components/grid/filter-data/filter-menu).
