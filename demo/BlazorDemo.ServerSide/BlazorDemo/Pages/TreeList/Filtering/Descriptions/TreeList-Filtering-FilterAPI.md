The DevExpress Blazor TreeList allows you to filter data against every data source field, including fields not displayed within the TreeList. The [FilterTreeMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.FilterTreeMode) property specifies how the TreeList component displays filtered nodes:

*   `ParentBranch` (Default) — The component displays a node that meets the filter criteria and all its parent nodes, even if they do not meet the criteria.
*   `EntireBranch` — The component displays a node that meets the filter criteria and all its parent and child nodes, even if they do not meet the criteria.

To filter data, create a [criteria operator](https://docs.devexpress.com/CoreLibraries/2129/devexpress-data-library/criteria-operators) object that specifies a filter expression. Send this object to the [SetFilterCriteria](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.SetFilterCriteria(DevExpress.Data.Filtering.CriteriaOperator)) method. Once you call this method, the TreeList clears all filters applied previously. 

You can apply a filter to a column without resetting an existing filter. Pass a criteria operator object to the [SetFieldFilterCriteria](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.SetFieldFilterCriteria(System.String-DevExpress.Data.Filtering.CriteriaOperator)) method to apply the filter to a specific data field. This method uses the AND operator to combine filters for different columns.

Call the following methods to obtain currently applied filters:

* [GetFilterCriteria](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.GetFilterCriteria) — Returns the criteria operator applied to the TreeList.
* [GetFieldFilterCriteria](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.GetFieldFilterCriteria(System.String)) — Returns the criteria operator applied to a specified data field.

To react to filter criteria changes, handle the [FilterCriteriaChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.FilterCriteriaChanged) event.

This demo creates a criteria operator object based on the current value of the tag box. The [SetFieldFilterCriteria](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.SetFieldFilterCriteria(System.String-DevExpress.Data.Filtering.CriteriaOperator)) method is called to apply the criteria operator to the **Type** column.
