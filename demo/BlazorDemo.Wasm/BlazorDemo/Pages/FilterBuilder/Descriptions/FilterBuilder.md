The DevExpress Blazor [Filter Builder](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFilterBuilder) allows users to create complex filter criteria. This component uses our [CriteriaOperator](https://docs.devexpress.com/CoreLibraries/4928/devexpress-data-library/criteria-language-syntax) language and can be connected to any data-aware DevExpress Blazor component.

The Filter Builder component ships with the following key features and capabilities:

* Logical conditions
* Operator variety
* Field configuration
* Hierarchical fields
* Data type-specific editors
* Data editor customization
* Lookup values for foreign keys

In this demo, the Filter Builder is bound to the DevExpress Blazor [Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid) component (using the [DxFilterBuilder.FilterCriteria](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFilterBuilder.FilterCriteria) property). Click the **Apply** button to filter grid data (using a [DxGrid.SetFilterCriteria](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SetFilterCriteria(DevExpress.Data.Filtering.CriteriaOperator)) method call) or the **Clear** button to clear all filter conditions. 
