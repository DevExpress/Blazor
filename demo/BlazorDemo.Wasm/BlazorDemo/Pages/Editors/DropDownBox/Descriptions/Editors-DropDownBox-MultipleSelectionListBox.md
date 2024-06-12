DevExpress Blazor [DropDownBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDownBox) is a highly customizable editor that can display any UI element within its drop-down window. These includ simple lists, trees, grids, or a combination of multiple elements. The editor's input element is read-only for users. You can assign an editor value programmatically based on user interaction with window content.

Place the drop-down window content in the [DropDownBodyTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDownBox.DropDownBodyTemplate) template.

In this demo, the editor's drop-down window contains a [DxListBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2) component that allows multi-item selection. When a user changes selection, the corresponding value is assigned to the DropDownBox [Value](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDownBox.Value) property.

The [QueryDisplayText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDownBox.QueryDisplayText) property allows you to define how the editor value is displayed in the input element.
