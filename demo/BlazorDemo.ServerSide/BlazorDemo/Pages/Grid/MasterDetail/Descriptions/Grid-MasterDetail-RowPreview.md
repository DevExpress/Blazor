This demo illustrates how to display preview sections under each [Grid](https://docs.devexpress.com/Blazor/403143/grid) data row across all columns. These sections can display any content, including tables, values from data source fields, custom text, etc. To replicate the capabilities of this demo, follow the steps below:

1. Add a grid to your application.
2. Bind the grid to data and add columns to its [Columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.Columns) collection.
3. Add the [DetailRowTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.DetailRowTemplate) to the grid's markup and define a row preview template.
4. Set the [DetailRowDisplayMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.DetailRowDisplayMode) property to `GridDetailRowDisplayMode.Always`.
