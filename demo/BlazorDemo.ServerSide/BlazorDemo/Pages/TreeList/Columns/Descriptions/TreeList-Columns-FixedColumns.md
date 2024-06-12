Fixed (anchored) columns can improve data readability as they remain visible when a user scrolls the TreeList horizontally.

The DevExpress Blazor TreeList allows you to anchor columns to the TreeList's left or right edge. To introduce this capability in your next DevExpress-powered Blazor app, set the column's [FixedPosition](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListColumn.FixedPosition) property to `Left` or `Right`.

Just as with standard columns, users can display/hide fixed columns or change order and size. However, users cannot move standard columns to a fixed column zone and vice versa.

In this demo, the **Name** and **Type** columns are anchored to the TreeList's left and right edges, respectively. Scroll the TreeList horizontally to view how this affects data readability.
