The following example shows a standard **EditForm** component with a few DevExpress editors in it:

*   [Text Box](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTextBox)
*   [ComboBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2)
*   [Spin Edit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSpinEdit-1)
*   [Date Edit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDateEdit-1)

Once you attempt to submit changes, editors become marked with colored outlines. Red indicates invalid values, while green indicates values that were posted successfully. You can also use the [ShowValidationIcon](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Configuration.GlobalOptions.ShowValidationIcon) global option or an editor's [ShowValidationIcon](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxInputDataEditorBase-1.ShowValidationIcon) property to specify whether editors should display validation icons.

The code also adds a standard **ValidationMessage** component for each editor to display error messages.
