The [CustomizeContextMenu](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit.CustomizeContextMenu) event allows you to access and customize the context menu used within the DevExpress Blazor [Rich Text Editor](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit). You can customize or remove existing commands or add root-level and nested [menu items](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Office.IContextMenuItem) as needed.

This demo customizes the context menu in the following manner:

* Adds custom *Google Search...* and *Show URL* items to the main menu and configures associated behaviors. The *Show URL* item is visible when a hyperlink is selected.
* Adds a new *Show URL* item to the start of the hyperlink group.
* Creates a custom *Clipboard* item and adds it to the main menu.
* Removes built-in *CutSelection*, *CopySelection*, and *Paste* items from the main menu and adds them as sub-menu items to the new *Clipboard* item.

To disable context menu functionality, set the [ContextMenuEnabled](http://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit.ContextMenuEnabled) property to `false`.
