This demo highlights built-in drag & drop operations available to you (reorder, move multiple rows simultaneously, drop options, etc).

Activate the [AllowDragRows](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.AllowDragRows) option to render drag handles for data rows. The [AllowedDropTarget](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.AllowedDropTarget) property specifies drag & drop-related constraints:

* **All** - Users can reorder rows within the originating Grid and drop them onto other components.
* **External** - Users can drop rows onto other components.
* **Internal** - Users can reorder rows within the originating Grid.
* **None** - Users cannot reorder rows or drop them onto a Grid from another component.

The target component's [ItemsDropped](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ItemsDropped) event handler updates data sources accordingly.
