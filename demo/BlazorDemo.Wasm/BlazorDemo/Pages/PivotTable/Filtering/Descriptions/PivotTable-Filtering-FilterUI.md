The DevExpress Blazor [Pivot Table](https://docs.devexpress.com/Blazor/405245/pivot-table) allows you to define **filter fields**. These fields do not display data in the table, but allow users to filter Pivot Table data based on their values. You can define filter fields in component markup or drag them from other Pivot Table areas.

The Pivot Table displays filter field headers in the Filter Header Area. Use the [FilterHeaderAreaDisplayMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.PivotTable.DxPivotTable.FilterHeaderAreaDisplayMode) property to control Filter Header Area visibility.

You can apply filters to both **filter fields** and to **row/column fields**. For all these fields, the Pivot Table displays filter menu buttons within associated headers. When a user clicks a filter menu button for a given field, the Pivot Table displays a Filter Menu with all unique values within the field. Users can select/deselect these values to filter Pivot Table data. Users can resize the Filter Menu using the size grip positioned at the bottom right corner.

You can use the following properties to control filter menu button visibility:
* [DxPivotTable.FilterMenuButtonDisplayMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.PivotTable.DxPivotTable.FilterMenuButtonDisplayMode) - Specifies whether a filter menu button is visible for all filter field headers.
* [DxPivotTableField.FilterMenuButtonDisplayMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.PivotTable.DxPivotTableField.FilterMenuButtonDisplayMode) - Specifies whether a filter menu button is visible for a specific field.

You can use the following APIs to customize the filter menu as requirements dictate:

* The [CustomizeFilterMenu](https://docs.devexpress.com/Blazor/DevExpress.Blazor.PivotTable.DxPivotTable.CustomizeFilterMenu) event fires before the drop-down filter is displayed and allows you to customize filter items.
* The [FilterMenuTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.PivotTable.DxPivotTableField.FilterMenuTemplate) property specifies the template used for the content displayed within the field's drop-down filter. You can switch between [hierarchical](https://docs.devexpress.com/Blazor/DevExpress.Blazor.PivotTable.PivotTableFieldFilterMenuTemplateContext.HierarchicalDateView) and [list](https://docs.devexpress.com/Blazor/DevExpress.Blazor.PivotTable.PivotTableFieldFilterMenuTemplateContext.ListView) views for **DateTime**, **DateTime?**, and **DateOnly** values in this template.
* The [FieldFilterMenuTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.PivotTable.DxPivotTable.FieldFilterMenuTemplate) property specifies the template used for all drop-down filter menus in the Pivot Table.

In this demo, we use the [FilterMenuTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.PivotTable.DxPivotTableField.FilterMenuTemplate) to customize filter menus for the **MPGCity** and **MPGHighway** fields. Templates allow you to include custom filter options in your Blazor-powered web app.

For additional information, refer to the following topic: [Field Filter Menu](https://docs.devexpress.com/Blazor/405367/components/pivottable/filter-data#filter-ui).

