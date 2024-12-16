This demo highlights built-in drag & drop operations available to you (you can reorder rows and move them between TreeList and Grid components). For instance, you can select multiple rows in the **Pending Task**s Grid and move the entire selection as a single drag-and-drop operation to the **Planned Tasks** TreeList.

Activate the [AllowDragRows](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.AllowDragRows) option to render drag handles for data rows. The [AllowedDropTarget](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.AllowedDropTarget) property specifies drag & drop-related constraints:

* **All** - Users can reorder rows within the originating TreeList and drop them onto other components.
* **External** - Users can drop rows onto other components.
* **Internal** - Users can reorder rows within the originating TreeList.
* **None** - Users cannot reorder rows or drop them onto this TreeList from another component.

The target component's `ItemsDropped` event handler updates data sources accordingly.
