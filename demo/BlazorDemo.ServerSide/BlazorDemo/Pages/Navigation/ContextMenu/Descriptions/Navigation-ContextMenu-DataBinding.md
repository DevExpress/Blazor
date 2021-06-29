You can bind the Context Menu to hierarchical data structures to populate menu items. Follow the steps below: 

1. Use the Context Menu's [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxContextMenu.Data) property to specify a data source. 
2. Add the [\<DataMappings>](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxContextMenu.DataMappings) tag to the component markup. 
3. In the `<DataMappings>` tags, create the [DxContextMenuDataMapping](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxContextMenuDataMapping) instance and map [item properties](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxContextMenuDataMapping._members#properties) to data source fields. Mappings are used to adjust the Context Menu's data model to the data source. For hierarchical data, the [Children](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDataMappingBase-1.Children) property is required.  
