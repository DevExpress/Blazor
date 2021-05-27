The DevExpress [TreeView](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView#bind-to-data) for Blazor allows you to load data from several data sources and display the master-detail relationships within the component.

This demo module binds the TreeView to three data sources and populates component nodes as follows:

*   First-level nodes are bound to an array of _ProductCategoryMain_ items via the component's [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView.Data) property.
*   Second-level nodes are obtained from the second data source. Each node is represented by the _ProductCategory_ object and depends on a parent value (the corresponding first-level node).
*   Third-level nodes are obtained from the third data source. Each node is represented by the _Product_ object based on a master-detail relationship between the second and third data sources. This relationship is established through the _ProductCategory.SubcategoryID_ and _Product.ProductCategoryId_ properties.
