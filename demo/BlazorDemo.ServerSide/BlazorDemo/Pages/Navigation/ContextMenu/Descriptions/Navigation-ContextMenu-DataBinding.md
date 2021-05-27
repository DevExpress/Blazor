The [Context Menu](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxContextMenu) can be bound to hierarchical data structures. Specify the following properties to bind the component to a hierarchical data structure:

*   [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxContextMenu.Data) - A Context Menu data source object.
*   [ChildrenExpression](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxContextMenu.ChildrenExpression) - A lambda expression that returns the data item’s children.

The following properties specify expressions that return menu item information (text, name, and so on):

*   [NameExpression](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxContextMenu.NameExpression) - A lambda expression that returns a menu item’s unique identifier (name).
*   [ClickExpression](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxContextMenu.ClickExpression) - A lambda expression that returns a handler for a menu item’s Click event.
*   [TextExpression](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxContextMenu.TextExpression) - A lambda expression that returns a menu item’s text.
*   [IconUrlExpression](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxContextMenu.IconUrlExpression) - A lambda expression that returns the URL of a menu item icon.
*   [BeginGroupExpression](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxContextMenu.BeginGroupExpression) - A lambda expression that specifies the start of an item group.
