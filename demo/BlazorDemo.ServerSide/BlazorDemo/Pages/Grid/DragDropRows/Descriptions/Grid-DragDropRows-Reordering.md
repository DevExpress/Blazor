This demo highlights the row re-ordering capabilities of the DevExpress Blazor Grid.

When you activate the [AllowDragRows](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.AllowDragRows) option, our Blazor Grid component renders a drag handle for each data row. When a user starts a drag operation, the drag hint displays row information on screen. Use the [DragHintTextTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.DragHintTextTemplate) to display a custom message within the drag hint.

The [ItemsDropped](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ItemsDropped) event fires when users drop rows onto the Grid ([AllowedDropTarget](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.AllowedDropTarget)). In the event handler, update the data source: insert rows at the drop position and remove them from the initial position, if required.
