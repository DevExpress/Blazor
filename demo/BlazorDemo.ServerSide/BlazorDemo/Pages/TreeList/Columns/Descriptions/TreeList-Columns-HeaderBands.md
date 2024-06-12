You can combine DevExpress Blazor TreeList headers into a hierarchy of higher-level groups (header bands). Our Blazor TreeList component supports unlimited band nesting levels. Users can use the column chooser or drag column headers to move columns within a band but cannot drag them to a different parent band.

To create a band, declare a [DxTreeListBandColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListBandColumn) object and specify nested columns in the [Columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListBandColumn.Columns) template.

This demo includes **Sales** and **Year-Over-Year Comparison** header bands.
