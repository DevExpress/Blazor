When you activate the [AllowDragRows](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.AllowDragRows) option, our Blazor TreeList component renders a drag handle for each data row. When a user starts a drag operation, the drag hint displays row information on screen. Use the [DragHintTextTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.DragHintTextTemplate) to display a custom message within the drag hint.

The [ItemsDropped](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ItemsDropped) event fires when users drop rows onto the Blazor TreeList ([AllowedDropTarget](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.AllowedDropTarget)). In the event handler, update the data source: insert rows at the drop position and remove them from the initial position, if required.

This demo allows you to reorder TreeList rows and change row hierarchy. Note the drop target indicator:

* **A line between rows**: inserts the row above the line.
* **A frame around a row**: inserts the row as a child.
