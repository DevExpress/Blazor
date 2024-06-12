You can combine DevExpress Blazor Grid headers into a hierarchy of higher-level groups (header bands). To address a broad range of usage scenarios, our Blazor Grid component supports unlimited nesting levels for bands displayed within the component. Users can use the column chooser or drag column headers to move columns within a band but cannot drag them out.

To create a band, declare a [DxGridBandColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridBandColumn) object and specify nested columns in the [Columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridBandColumn.Columns) template.

This demo uses **Order** and **Product** header bands to form a three-level hierarchy.
