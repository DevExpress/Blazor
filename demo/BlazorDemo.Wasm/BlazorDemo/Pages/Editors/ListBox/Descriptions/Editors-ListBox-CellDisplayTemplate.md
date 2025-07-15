This demo customizes cell appearance in a multi-column List Box.

Use the [DxListEditorColumn.CellDisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListEditorColumn.CellDisplayTemplate) property to specify cell rendering for a specific column. You can format data, apply CSS styles, and add custom HTML markup.

The `CellDisplayTemplate` property gives you access to cell context through a `ListBoxColumnCellDisplayTemplateContext` object:

- The underlying data object (the `DataItem` property)
- The parent column (the `Column` property)
- Other relevant information about the cell (value, state, display text, sequential index, etc.)
