The DevExpress Blazor Grid ships with a built-in Filter Builder dialog. This dialog allows users to edit and combine filter criteria applied to Grid columns. To open the dialog, click the **Filter Builder** toolbar item or use the Filter Panel.

Our Blazor Grid automatically generates and configures Filter Builder fields based on column settings. The filter field hierarchy reflects the column band hierarchy. If the default field configuration does not meet requirements, you can customize the dialog using the [FilterBuilderTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.FilterBuilderTemplate).

This demo adds a custom **Shipping Info** group to the Filter Builder dialog. Filter items in this group are bound to data source fields not associated with Grid columns.
