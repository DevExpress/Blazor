Our [Form Layout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayout) component allows you to easily construct responsive and automatically-aligned edit forms. The standard **EditForm** component enables data validation. This demo shows how you can use the two components together.

Inside the **EditForm**, the code adds a [Form Layout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayout) component with five [layout items](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutItem). Each item contains a DevExpress Data Editor:

*   [Text Box](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTextBox)
*   [ComboBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2)
*   [Spin Edit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSpinEdit-1)
*   [Date Edit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDateEdit-1)
*   [Memo](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMemo)

The **EditForm** also contains the DevExpress [Button](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxButton) component with the [SubmitFormOnClick](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxButton.SubmitFormOnClick) option set to **true**. Once you attempt to submit changes, editors become marked with colored outlines. Red indicates invalid values, while green indicates values that were posted successfully. You can also use the [ShowValidationIcon](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Configuration.GlobalOptions.ShowValidationIcon) global option or an editor's [ShowValidationIcon](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxInputDataEditorBase-1.ShowValidationIcon) property to specify whether editors should display validation icons.

Below the form, the standard Blazor **ValidationSummary** component displays the validation summary.
