The DevExpress Blazor TreeList ships with a built-in Filter Builder dialog. This dialog allows users to edit and combine filter criteria applied to TreeList columns. To open the dialog, click the **Filter Builder** toolbar item or use the Filter Panel.

Our Blazor TreeList automatically generates and configures Filter Builder fields based on column settings. The filter field hierarchy reflects the column band hierarchy. If the default field configuration does not meet requirements, you can customize the dialog using the [FilterBuilderTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.FilterBuilderTemplate).

This demo adds a custom **Status** filter item to the Filter Builder dialog. This item is bound to a data source field not associated with TreeList columns.

The [FilterTreeMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.FilterTreeMode) property specifies whether the TreeList component displays child/parent records for rows that meet filter criteria. Use the **Display Nodes** dropdown list to try different filter modes
