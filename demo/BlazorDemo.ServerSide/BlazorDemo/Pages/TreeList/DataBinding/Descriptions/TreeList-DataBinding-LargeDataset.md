You can use the [GridDevExtremeDataSource\<T>](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridDevExtremeDataSource-1) class to bind the DevExpress Blazor TreeList to a large [IQueryable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.linq.iqueryable-1) data collection. This data source implementation is based on our [DevExtreme.AspNet.Data](https://github.com/DevExpress/DevExtreme.AspNet.Data) library. When you use this data source, the TreeList component performs the following actions to optimize performance and reduce overall memory consumption:

* Loads child nodes when the node is expanded for the first time.
* Delegates data filtering operations to an underlying query provider.
* Switches [FilterTreeMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.FilterTreeMode) to `Nodes`. In this mode, the TreeList ignores parent-child relationships and displays all nodes that meet the filter criteria at one level.

To use this data source in your next Blazor project, follow the steps below:

1. Create a [GridDevExtremeDataSource\<T>](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridDevExtremeDataSource-1) class instance and pass your [IQueryable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.linq.iqueryable-1) data collection as the constructor parameter. Assign the result to the TreeList's [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.Data) property.
2. Specify [KeyFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.KeyFieldName) and [ParentKeyFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ParentKeyFieldName) properties. The component uses them to build the tree.
3. Specify the [HasChildrenFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.HasChildrenFieldName) property. The component uses this property to determine which nodes require expand buttons.

To help illustrate the performance benefits of [GridDevExtremeDataSource\<T>](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridDevExtremeDataSource-1), this demo is linked to a dataset with over 100,000 nodes. You can expand or collapse nodes, and filter or sort data to evaluate the performance/responsiveness.
