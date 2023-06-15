The DevExpress Blazor [Grid](https://docs.devexpress.com/Blazor/403143/grid) allows you to filter data in code.

To apply filter criteria, create a [criteria operator](https://docs.devexpress.com/CoreLibraries/2129/devexpress-data-library/criteria-operators) object that specifies a filter expression and send this object to the [SetFilterCriteria](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SetFilterCriteria(DevExpress.Data.Filtering.CriteriaOperator)) method. When you call this method, the Grid clears all filters applied previously. 

You can apply a filter to a column without resetting an existing filter. Pass a criteria operator object to the [SetFieldFilterCriteria](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SetFieldFilterCriteria(System.String-DevExpress.Data.Filtering.CriteriaOperator)) method to apply the filter to a particular data field. This method uses the AND operator to combine filters for different columns. These methods allow you to filter Grid data against every data source field, including fields not displayed within the Grid.

When a filter is applied, the Grid raises the [FilterCriteriaChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.FilterCriteriaChanged) event.

You can use the following methods to get currently applied filters:

* [GetFilterCriteria](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.GetFilterCriteria) — Returns the criteria operator applied to the Grid.
* [GetFieldFilterCriteria](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.GetFieldFilterCriteria(System.String)) — Returns the criteria operator applied to the specified data field.

In this demo, we create a criteria operator object based on the current value of the tag box. The [SetFieldFilterCriteria](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SetFieldFilterCriteria(System.String-DevExpress.Data.Filtering.CriteriaOperator)) method is called to apply the criteria operator to the **CategoryId** column.
