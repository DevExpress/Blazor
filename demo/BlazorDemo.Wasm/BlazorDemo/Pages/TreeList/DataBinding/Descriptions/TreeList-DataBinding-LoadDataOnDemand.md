The DevExpress Blazor TreeList can load child nodes when a user expands a parent node for the first time. This capability improves performance and reduces overall memory consumption when the control is bound to a large dataset. Follow the steps below to enable on-demand loading mode in the DevExpress Blazor TreeList component:

1. Assign a collection of root data items to the [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.Data) property.
2. Specify the [HasChildrenFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.HasChildrenFieldName) property. The component uses this property to determine which nodes require expand buttons.
3. Handle the [ChildrenLoadingOnDemand](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ChildrenLoadingOnDemand) event. In the event handler, use the [Parent](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TreeListChildrenLoadingEventArgs.Parent) argument to determine the processed node and assign the node's children to the [Children](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TreeListChildrenLoadingEventArgs.Children) event argument.

In the demo, the TreeList component uses this data binding method to display the file/folder structure of this web site.
