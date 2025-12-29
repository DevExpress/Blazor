The DevExpress Blazor [Filter Builder](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFilterBuilder) allows you to display its built-in text editor to modify a filter condition (in addition to the interactive tree view). Use the [ViewMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFilterBuilder.ViewMode) property to specify `Visual` or `VisualAndText` mode.

Check the **Text Editor** checkbox to activate `VisualAndText` mode and modify filter expressions in the text editor.

In `VisualAndText` mode, the Filter Builder supports [Blazor form validation](https://learn.microsoft.com/en-us/aspnet/core/blazor/forms/validation) and allows you to obtain component edit context using the [GetEditContext](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFilterBuilder.GetEditContext) method (to apply validation rules if necessary).

This demo disables the **Apply** button when you enter an invalid filter expression into the text editor.
