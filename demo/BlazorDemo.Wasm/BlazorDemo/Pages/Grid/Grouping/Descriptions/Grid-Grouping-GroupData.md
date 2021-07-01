Our Blazor [Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid) allows users to group data. To enable data grouping and display the Group panel, set the [ShowGroupPanel](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ShowGroupPanel) property to `true`. Users can drag and drop a column header onto the Group Panel to group data against the column. They can also drag headers within this panel to change group order. To ungroup data, users can simply drag the appropriate column header from the Group Panel back to the Column Header Panel.

To disable grouping, set the [DxGrid.AllowGroup](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.AllowGroup) or [DxGridColumn.AllowGroup](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridColumn.AllowGroup) property to `false` (applied to the entire Grid or to an individual column). 

Use the following API members to manage data grouping in code:

* [DxGrid.GroupBy](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.GroupBy) - Groups Grid data against the specified column. 
* [DxGridColumn.GroupIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.GroupIndex) - Specifies a column's index among grouped columns. If the property is set to `-1`, grid data is not grouped by this column. 
* [DxGrid.CollapseGroupRow](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CollapseGroupRow), [DxGrid.CollapseAllGroupRows](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CollapseAllGroupRows)  - Collapse an individual group row or all group rows. 
* [DxGrid.ExpandGroupRow](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ExpandGroupRow), [DxGrid.ExpandAllGroupRows](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ExpandAllGroupRows) - Expand an individual group row or all group rows. 
* [DxGrid.AutoExpandAllGroupRows](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.AutoExpandAllGroupRows) - Expands all group rows automatically when the Grid loads data or users interact with the Grid. 
* [DxGrid.ShowGroupedColumns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ShowGroupedColumns) - Specifies whether to display grouped columns among other columns in the Grid.  
