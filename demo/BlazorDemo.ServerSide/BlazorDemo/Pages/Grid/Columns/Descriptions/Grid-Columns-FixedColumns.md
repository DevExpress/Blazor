Fixed (anchored) columns can improve data readability as they remain visible when a user scrolls the Grid horizontally.

The DevExpress Blazor [Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid) allows you to anchor columns to the Grid's left or rightmost edge. To anchor a column, set the desired column's [FixedPosition](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridColumn.FixedPosition) property to `Left` or `Right`.

Just as with regular columns, users can display/hide fixed columns or change their order and size. However, users cannot move regular columns to a fixed column zone and vice versa.

In this demo, [selection](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridSelectionColumn) and **Company Name** columns are anchored to the Grid's leftmost edge. The check box above the Grid allows you to anchor the **City** column to the rightmost edge. Scroll the Grid horizontally to experience the visual/readability impact made by fixed columns.
