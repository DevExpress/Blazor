The [TagBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2) component provides access to item values. The value is assigned to the editor's edit value when a user selects an item from the drop-down list. To enable this access, set the [ValueFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2.ValueFieldName) property to the name of the data source field that ships with values for the TagBox items.

If the **ValueFieldName** property is not specified, the TagBox component searches for a **Value** field in the data source and uses this field as a value field. Otherwise, values are not assigned to editor items.

To access values of the selected items, use the [Values](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2.Values) property. To track selection changes, use the [ValuesChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2.ValuesChanged) event or two-way synchronization as demonstrated in this module.
