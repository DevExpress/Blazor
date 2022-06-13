A layout group ([DxFormLayoutGroup](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutGroup)) is a container for layout items ([DxFormLayoutItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutItem)) and other layout groups.

The main group properties are:
* A set of [ColSpanXX](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutGroup._members) properties - Specifies the width of a group.
* [Caption](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.FormLayoutItemBase.Caption) – Specifies the group caption.
* [Enabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.FormLayoutItemBase.Enabled) - Specifies whether auto-generated editors in groups are enabled.
* [HeaderTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutGroup.HeaderTemplate) - Specifies the group header template. If you specify this property value, wrap the main group content in the [Items](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutGroup.Items) component.
* [HeaderCssClass](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutGroup.HeaderCssClass) - Sets a custom CSS class applied to a group header.
* [ReadOnly](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.FormLayoutItemBase.ReadOnly) - Specifies whether the group activates read-only mode for all nested auto-generated editors.

In this demo, the template adds the **Unemployed** checkbox to a group header. Click this checkbox to disable group items.
