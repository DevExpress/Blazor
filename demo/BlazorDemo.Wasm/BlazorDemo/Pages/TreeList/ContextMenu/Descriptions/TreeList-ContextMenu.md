The DevExpress Blazor TreeList allows you to display Context Menus with both predefined and custom commands. Use the [ContextMenus](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ContextMenus) property to activate Context Menus for specific TreeList elements. Handle the [CustomizeContextMenu](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.CustomizeContextMenu) event to modify the menu item collection.

This demo uses Context Menus for the following Blazor TreeList elements: 

- Column Headers
- Data Rows (custom item deletes the row)
- Footer Cells (custom items add/remove total summaries)