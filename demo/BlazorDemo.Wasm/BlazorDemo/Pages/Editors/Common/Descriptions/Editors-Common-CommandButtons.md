DevExpress Blazor Editors display built-in command buttons that allow users to open a dropdown, increase/decrease values, or clear editor content as needs dictate. You can use `Show***Button` properties to hide these buttons.

You can also customize built-in editor command buttons or add custom buttons to editors. 

The following built-in buttons are available:

* [DxComboBoxDropDownButton](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBoxDropDownButton) — Invokes a drop-down menu in the [DxComboBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2) component.
* [DxDateEditDropDownButton](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDateEditDropDownButton) — Invokes a drop-down calendar in the [DxDateEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDateEdit-1) component.
* [DxDropDownBoxDropDownButton](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDownBoxDropDownButton) — Invokes a drop-down window in the [DxDropDownBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDownBox) component. 
* [DxSpinButtons](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSpinButtons) — Spin buttons that allow you to increase and decrease the value in the [DxSpinEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSpinEdit-1) component.
* [DxTimeEditDropDownButton](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTimeEditDropDownButton) — Invokes a drop-down time picker in the [DxTimeEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTimeEdit-1) component.

The following button types are available for [DxComboBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2), [DxDateEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDateEdit-1), [DxMaskedInput](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMaskedInput-1), [DxDropDownBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDownBox), [DxSpinEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSpinEdit-1), [DxTextBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTextBox), and [DxTimeEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTimeEdit-1) components:

* [DxEditorButton](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxEditorButton) — A custom button.

Buttons are displayed in an editor in the following order:

- The "Clear" button
- Custom buttons and customized default buttons (in the same order as they appear in markup)
- Built-in buttons

This demo adds buttons to different editors as follows:

* ComboBox — "Add Employee" button
* SpinEdit — "Currency" button
* SpinEdit — "Large Increment" button
* DateEdit — "Next Date" and "Previous Date" buttons
* MaskedInput — "Send Email" button
