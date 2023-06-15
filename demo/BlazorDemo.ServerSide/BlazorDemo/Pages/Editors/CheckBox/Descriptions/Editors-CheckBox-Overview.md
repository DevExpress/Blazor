The [CheckBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxCheckBox-1) component allows users to select yes/no or true/false. To change the editor's state (check/uncheck/indeterminate), click it or press SPACE when the editor is focused.

You can [bind](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxCheckBox-1#checkbox-states) the CheckBox's state to Boolean, Nullable Boolean, Enum, Int16, and other property types.

The main CheckBox API members are listed below.

* [Checked](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxCheckBox-1.Checked) - Specifies whether the checkbox editor is checked.
* [CheckedChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxCheckBox-1.CheckedChanged) - Fires when the editor's state changes.
* [LabelPosition](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxCheckBox-1.LabelPosition) - Specifies the position of the editor's child content relative to the check mark.
* [Enabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDataEditorBase-2.Enabled) - Specifies whether the editor is enabled.

In the example above, the **Select All** checkbox is bound to a Nullable Boolean variable that supports three states: checked, unchecked, and indeterminate. The indeterminate state is activated if the other checkboxes have different states (checked or unchecked).
