Set the [AllowTabReorder](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTabs.AllowTabReorder) property to `true` to drag & drop tab headers and reorder them as needed. When a user drops a tab, the component raises the [TabReordering](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTabs.TabReordering) event. You can use event argument properties to obtain information about tab position (both old and new position) and cancel the action if necessary.

In this demo, tabs display **Close** buttons in their headers because the [AllowClose](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxTabBase.AllowClose) property is `true`. Users can close a tab in the following manner:

* Click the **Close** button in the tab header.
* Press the Delete key.

Before closing a tab, the component raises the [TabClosing](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTabs.TabClosing) event. This event allows you to obtain information about the tab being processed, identify the action that raised the event, and cancel the action if necessary.
