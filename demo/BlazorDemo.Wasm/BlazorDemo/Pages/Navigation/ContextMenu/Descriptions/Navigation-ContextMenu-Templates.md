The Context Menu component allows you to use templates to customize the layout and appearance of menu items.

Use the following properties to specify default templates for all items:
* [DxContextMenu.ItemTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxContextMenu.ItemTemplate)
* [DxContextMenu.ItemTextTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxContextMenu.ItemTextTemplate)
* [DxContextMenu.SubMenuTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxContextMenu.SubMenuTemplate)

The following members allow you to set templates for individual items (they override the default templates):

* [DxContextMenuItem.Template](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxContextMenuItem.Template)
* [DxContextMenuItem.TextTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxContextMenuItem.TextTemplate)
* [DxContextMenuItem.SubMenuTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxContextMenuItem.SubMenuTemplate)

This module demonstrates how to define submenu templates for the **Text color** and **Background** color menu items. The **Reset Colors** item is [disabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxNavigationItemBaseComponent-1.Enabled) until you select text or background color.
