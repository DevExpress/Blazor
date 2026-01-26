The DevExpress Blazor [Pivot Table](https://docs.devexpress.com/Blazor/405245/pivot-table) allows you to save and restore its layout. With this capability, you can:

- Persist layout between application runs to retain user modifications.
- Allow users to save a preferred layout and return to the layout when necessary. 
- Configure pre-defined layouts and allow users to switch between them. 

In this demo, changes you make in the Pivot Table layout persist after a page reload operation. You can reorder fields, apply filters, expand/collapse rows and columns. Once you make your modifications, click the **Reload Page** button above the Pivot Table and ensure that your changes persist. If you wish to reset the layout to the state specified in the markup, click **Reset Layout**.

A [saved layout object](https://docs.devexpress.com/Blazor/DevExpress.Blazor.PivotTable.PivotTablePersistentLayout) includes user customizable settings: field settings (area, area index, sort order, visibility), filter criteria, and expand/collapse state of rows and columns.

Handle the following events to persist Pivot Table layout:

* [LayoutAutoSaving](https://docs.devexpress.com/Blazor/DevExpress.Blazor.PivotTable.DxPivotTable.LayoutAutoSaving) — Raised when layout settings change. The event's [e.Layout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.PivotTable.PivotTablePersistentLayoutEventArgs.Layout) argument contains a [PivotTablePersistentLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.PivotTable.PivotTablePersistentLayout) object with updated layout settings. Save this object to desired storage (in this demo, the browser's [local storage](https://learn.microsoft.com/en-us/aspnet/core/blazor/state-management/protected-browser-storage) is used). When you need to restore the Pivot Table layout, retrieve the object from the storage and apply it to the Pivot Table (for example, in the [LayoutAutoLoading](https://docs.devexpress.com/Blazor/DevExpress.Blazor.PivotTable.DxPivotTable.LayoutAutoLoading) event handler).
* [LayoutAutoLoading](https://docs.devexpress.com/Blazor/DevExpress.Blazor.PivotTable.DxPivotTable.LayoutAutoLoading) — Raised when the Pivot Table is initialized. The component begins loading the layout after it applies the initial state specified in markup. To load layout settings from a previously saved [PivotTablePersistentLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.PivotTable.PivotTablePersistentLayout) object, assign it to this event's [e.Layout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.PivotTable.PivotTablePersistentLayoutEventArgs.Layout) argument.

You can also call the [SaveLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.PivotTable.DxPivotTable.SaveLayout) and [LoadLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.PivotTable.DxPivotTable.LoadLayout(DevExpress.Blazor.PivotTable.PivotTablePersistentLayout)) methods to save/restore Pivot Table layout on demand (for example, on a button click).
