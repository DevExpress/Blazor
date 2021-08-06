The DevExpress Menu component allows you to load data from a data source to create menu items. Follow the steps below to bind the Menu to data: 

1. Use the Menu's [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMenu.Data) property to specify a data source.
2. Add the [\<DataMappings>](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMenu.DataMappings) tag to the component markup.
3. In the `<DataMappings>` tags, create the [DxMenuDataMapping](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMenuDataMapping) instance and map [item properties](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMenuDataMapping._members#properties) to data source fields. Mappings are used to adjust the Menu's data model to the data source.
	For flat data, the [Key](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDataMappingBase-1.Key) and the [ParentKey](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDataMappingBase-1.ParentKey) property is required. 
	For hierarchical data, the [Children](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDataMappingBase-1.Children) property is required. 