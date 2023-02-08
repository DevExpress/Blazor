DevExpress Blazor Editors display built-in command buttons that allow users to open a dropdown, increase/decrease values, or clear editor content as needs dictate. You can use `Show***Button` properties to hide these buttons.

You can also customize built-in editor command buttons or add custom buttons to editors. 

The following built-in buttons are available:

* [DxComboBoxDropDownButton](https://docs.devexpress.com/Blazor/DxComboBoxDropDownButton) -  Invokes a drop-down menu ([DxComboBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2) only).
* [DxDateEditDropDownButton](https://docs.devexpress.com/Blazor/DxDateEditDropDownButton) - Invokes a drop-down calendar ([DxDateEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDateEdit-1) only).
* [DxSpinButtons](https://docs.devexpress.com/Blazor/DxSpinButtons) - Spin buttons that allow you to increase and decrease the value ([DxSpinEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSpinEdit-1) only).
* [DxTimeEditDropDownButton](https://docs.devexpress.com/Blazor/DxTimeEditDropDownButton) - Invokes a drop-down time picker ([DxTimeEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTimeEdit-1) only).

The following button types are available for [DxComboBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2), [DxDateEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDateEdit-1), [DxMaskedInput](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMaskedInput-1), [DxSpinEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSpinEdit-1), [DxTextBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTextBox), and [DxTimeEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTimeEdit-1) components:

* [DxEditorButton](https://docs.devexpress.com/Blazor/DxEditorButton) - A custom button.

Buttons are displayed in an editor in the following order:

- The "Clear" button
- Custom buttons and customized default buttons (in the same order as they appear in markup)
- Built-in buttons

This demo adds buttons to different editors as follows:

* ComboBox - "Add Employee" button
* SpinEdit - "Currency" button
* SpinEdit - "Large Increment" button
* DateEdit - "Next Date" and "Previous Date" buttons
* MaskedInput - "Send Email" button
