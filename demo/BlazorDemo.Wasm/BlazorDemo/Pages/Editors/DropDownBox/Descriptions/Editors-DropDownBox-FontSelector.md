The [DropDownBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDownBox) editor implements templates for three sections of the drop-down window area:

* [DropDownHeaderTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDownBox.DropDownHeaderTemplate): Specifies a template for the drop-down window's header area.
* [DropDownBodyTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDownBox.DropDownBodyTemplate): Specifies a template for the drop-down window's body. In this demo, editors in the template allow users to select text format settings.
* [DropDownFooterTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDownBox.DropDownFooterTemplate): Specifies a template for the drop-down window's footer region. In this demo, the template contains two [DxButton](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxButton) components that allow users to apply or cancel changes.

This demo uses the editor's [Value](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDownBox.Value) property to store text format settings as a `FontProperties` object. The [QueryDisplayText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDownBox.QueryDisplayText) function concatenates `FontProperties` object field values. The editor displays the resulting string in the input element.

The [DropDownClosing](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDownBox.DropDownClosing) event fires when a user closes the drop-down window. This demo handles this event to reset editor values.

Note: You must enclose your code between [BeginUpdate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxEditorBase.BeginUpdate) and [EndUpdate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxEditorBase.EndUpdate) method calls to set editor value/other settings in code.
