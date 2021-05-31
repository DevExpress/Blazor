The DevExpress [TreeView](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView#bind-to-data) supports binding to hierarchical data structures. A bound TreeView creates a node for each data item.

The following properties should be specified to bind TreeView to a hierarchical data structure:

*   [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView.Data) - A TreeView data source object.
*   [ChildrenExpression](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView.ChildrenExpression) - A lambda expression that returns the data item’s children.

The following properties specify expressions that return node information (text, name, and so on):

*   [TextExpression](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView.TextExpression) - A lambda expression that returns the node’s text.
*   [NameExpression](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView.NameExpression) - A lambda expression that returns the node’s unique identifier (name).
*   [IconCssClassExpression](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView.IconCssClassExpression) - A lambda expression that returns the name of a CSS class applied to the node’s icon.
*   [NavigateUrlExpression](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView.NavigateUrlExpression) - A lambda expression that returns the node’s target URL.
