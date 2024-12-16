Our Blazor [Form Layout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayout) component allows you to construct responsive and auto-aligned edit forms with ease. 

As you know the standard Blazor **EditForm** component offers data validation support. This demo illustrates how to use these two components together.

Inside the **EditForm**, sample code adds a [Form Layout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayout) component with five [layout items](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutItem). Each item contains a DevExpress data editor:

*   [Text Box](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTextBox)
*   [ComboBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2)
*   [Spin Edit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSpinEdit-1)
*   [Date Edit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDateEdit-1)
*   [Memo](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMemo)

The **EditForm** also contains a DevExpress [Button](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxButton) component with its [SubmitFormOnClick](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxButton.SubmitFormOnClick) option set to **true**.

Below the form, the standard Blazor **ValidationSummary** component displays the validation summary.

Blazor data editors can display validation icons and colored outlines based on validation results. By default, the editors display red outlines and error icons for invalid inputs. To indicate valid inputs, you can activate the **Show Validation Success State** option in this demo, or set the [ShowValidationSuccessState](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Configuration.GlobalOptions.ShowValidationSuccessState) global option or an individual editor's `ShowValidationSuccessState` property to `true` in your project.

You can also disable validation icon display. Use the **Show Validation Icons** option in this demo, or use the [ShowValidationIcon](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Configuration.GlobalOptions.ShowValidationSuccessState) global option or an individual editor's `ShowValidationIcon` property in your project.

You can also disable validation for editors. Simply set an editor's [ValidationEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxEditorBase.ValidationEnabled) property to `false`.