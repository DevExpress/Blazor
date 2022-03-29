The DevExpress Blazor [Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid) component allows you to create hierarchical layouts of any complexity and depth. This demo module illustrates how to use a nested grid component to visualize a master-detail relationship between two data tables. To replicate the capabilities of this demo, follow the steps below:

1. Add a master grid to your application.
2. Bind the master grid to data and add columns to its [Columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.Columns) collection.
3. Add the [DetailRowTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.DetailRowTemplate) to the grid's markup to create a detail view.
4. (Optional) We recommend that you allocate the detail grid to a separate component. Separation improves app structure and prevents excessive component redraw operations.
5. Add a second data grid to the template. Bind this grid to a detail data source that uses the template's `context` object as a filter criteria.
6. (Optional) To collapse an expanded detail row when a new detail row is displayed on-screen, set the [AutoCollapseDetailRow](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.AutoCollapseDetailRow) property to **true**.
