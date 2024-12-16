In both Blazor Server and Blazor WebAssembly-powered applications, you can use [GridDevExtremeDataSource\<T>](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridDevExtremeDataSource-1) to bind our Blazor [TreeList](https://docs.devexpress.com/Blazor/404942/components/treelist) to a large dataset supplied by an HTTP service. This data source implementation is based on our [DevExtreme.AspNet.Data](https://github.com/DevExpress/DevExtreme.AspNet.Data) library. When you use this data source, the TreeList component performs the following actions to optimize performance and reduce overall memory consumption:

* Loads child nodes when the node is expanded for the first time.
* Delegates data filtering operations to an underlying query provider.
* Switches [FilterTreeMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.FilterTreeMode) to `Nodes`. In this mode, the TreeList ignores parent-child relationships and displays all nodes that meet the filter criteria at one level.

Follow the steps below to bind a TreeList to a large data collection published as an HTTP service:

1. Create a [GridDevExtremeDataSource\<T>](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridDevExtremeDataSource-1) class instance and pass a URL to an HTTP service as the constructor parameter.
2. Assign this instance to the TreeList's [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.Data) property.
3. On the service side, [implement an API controller](https://docs.devexpress.com/AspNetCore/401020/devextreme-based-controls/concepts/bind-controls-to-data/api-controllers). Create action methods that use the [DataSourceLoader](https://devexpress.github.io/DevExtreme.AspNet.Data/net/api/DevExtreme.AspNet.Data.DataSourceLoader.html) class to create a [LoadResult](https://devexpress.github.io/DevExtreme.AspNet.Data/net/api/DevExtreme.AspNet.Data.ResponseModel.LoadResult.html) object based on load options.
4. Specify [KeyFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.KeyFieldName), [ParentKeyFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ParentKeyFieldName), and [HasChildrenFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.HasChildrenFieldName) properties.
