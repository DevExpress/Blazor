The DevExpress [TreeView](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView) for Blazor displays hierarchical data structures within a tree-like UI. The component can be used to simplify navigation within a web app or to display self-referenced information to end users.

A collection of TreeView nodes is populated by the [Nodes](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView.Nodes) parameter. For each node, you can also specify its child nodes (using the parent node's [Nodes](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeViewNode.Nodes) parameter), unique identifier, text, target URL, and so on.

The TreeView allows users to select a node with a mouse click. The selected node is automatically highlighted. The following API is related to the node selection:

*   [AllowSelectNodes](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView.AllowSelectNodes) — Controls whether nodes can be selected.
*   [SelectionChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView.SelectionChanged) — Occurs after node selection.
*   [GetSelectedNodeInfo](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView.GetSelectedNodeInfo) — Returns information about the currently selected node: name, text, etc.

Additionally, TreeView [supports synchronization](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView.AllowSelectNodes#node-selection-and-load-child-nodes-on-demand-mode) of the selected node with the path of the currently displayed page. To activate this feature, enable the [AllowSelectNodes](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView.AllowSelectNodes) option and specify the [NavigateUrl](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeViewNode.NavigateUrl) properties for required nodes. The left-hand navigation tree of this demo shows synchronization in action.
