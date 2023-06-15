Our Blazor [Radio](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxRadio-1) component allows you to create radio buttons and combine these buttons into groups (only one radio button within the group can be selected at any one time).

This demo includes two radio button groups. The first group, `general-radio-group`, is displayed initially. The second group, `aot-radio-group`, appears when a user selects radio button 1 or 2 in the first group.

Key Radio component API members include:

* [Value](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxRadio-1.Value) - Specifies the button's value.
* [GroupName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxRadio-1.GroupName) - Specifies the name of a radio group to which the button belongs.
* [GroupValue](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxRadio-1.GroupValue) - Specifies the group's selected button.
* [Enabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxRadio-1.Enabled) - Specifies whether the button is enabled.

Our Radio component supports different size modes. To specify the component size in code, use the [SizeMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxResizableEditorBase-2.SizeMode) property. To apply different size modes within this demo, use the drop-down list in the demo card's header.