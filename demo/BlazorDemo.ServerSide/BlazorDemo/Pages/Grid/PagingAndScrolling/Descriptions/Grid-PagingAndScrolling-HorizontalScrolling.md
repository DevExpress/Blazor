Our Blazor [Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid) displays a horizontal scrollbar when the total width of all columns exceeds the specified width of the component itself.

Use the [Width](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridColumn.Width) property to specify a column's width in relative or absolute units.

If you do not specify column widths, the Grid renders columns with equal widths (but not less than the [MinWidth](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridColumn.MinWidth) value) and wraps content if needed.

If the Grid contains at least one column whose width is unspecified, the Grid applies specified column widths first. Columns without specified widths occupy the remaining grid width in equal shares (but not less than the [MinWidth](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridColumn.MinWidth) value).

If the Grid contains columns whose widths are specified in absolute units while other column widths are specified in percentages, the Grid applies column widths specified in absolute units first. The remaining column widths are calculated in the specified percentages from the Grid’s total width (but not less than the [MinWidth](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridColumn.MinWidth) value).