The Menu component allows you to use templates to customize the layout and appearance of the menu title and menu items.

Use the [TitleTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMenu.TitleTemplate) property to specify the template for the menu title.

Use the following properties to specify common templates for all items:

*   [DxMenu.ItemTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMenu.ItemTemplate)
*   [DxMenu.ItemTextTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMenu.ItemTextTemplate)
*   [DxMenu.SubMenuTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMenu.SubMenuTemplate)

Use the following properties to specify templates for an individual item:

*   [DxMenuItem.Template](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMenuItem.Template)
*   [DxMenuItem.TextTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMenuItem.TextTemplate)
*   [DxMenuItem.SubMenuTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMenuItem.SubMenuTemplate)

Note that individual templates override common templates.

The demo above demonstrates how to use templates to create the **Search** and **User Profile** menu items.
