The DevExpress Blazor TreeList allows you to save its layout between individual browser sessions. TreeList [layout information](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TreeListPersistentLayout) includes user-modifiable settings such as column position, sort order/direction, current page number, and filter values.

To persist TreeList layout between sessions, handle the following events:

* [LayoutAutoSaving](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.LayoutAutoSaving): Raised when TreeList layout settings change. The event's [Layout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TreeListPersistentLayoutEventArgs.Layout) argument contains a [TreeListPersistentLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TreeListPersistentLayout) object with new layout settings. Save this object to storage (in this demo, we use the browser's [local storage](https://learn.microsoft.com/en-us/aspnet/core/blazor/state-management?view=aspnetcore-8.0&pivots=server#browser-storage-server)). When you need to restore a TreeList layout, retrieve the object from the storage and apply it to the TreeList.
* [LayoutAutoLoading](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.LayoutAutoLoading): Raised when the TreeList completes its state initialization (as specified in the markup). To load layout settings from a previously saved [TreeListPersistentLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TreeListPersistentLayout) object, assign it to this event's [Layout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TreeListPersistentLayoutEventArgs.Layout) argument.

You can also call [SaveLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.SaveLayout) and [LoadLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.LoadLayout(DevExpress.Blazor.TreeListPersistentLayout)) methods to save and restore a TreeList layout on demand (for example, on a button click).

In this demo, changes that you make will persist after page reload operations. To evaluate our implementation, simply reorder columns, sort data, or apply filters and press the Reload Page button to see whether your changes persist. If you want to reset the layout to its original state, simply click Reset Layout.

Note: Our Blazor TreeList does not save row expansion state.
