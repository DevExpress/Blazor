You can populate the Toolbar component with data from a flat or hierarchical data source. This demo demonstrates how to bind the component to a flat data item collection. Associated code performs the following:

* Uses the [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbar.Data) property to specify the data source. 
* Adds the [\<DataMappings>](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbar.DataMappings) tag to the component markup. 
* Creates a [DxToolbarDataMapping](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbarDataMapping) instance and maps [item properties](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbarDataMapping._members#properties) to data source fields. Mappings modify the Toolbar's data model to match the data source. 

If the data source uses flat data, [Key](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDataMappingBase-1.Key) and [ParentKey](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDataMappingBase-1.ParentKey) properties are required. For hierarchical data, the [Children](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDataMappingBase-1.Children) property is required.
