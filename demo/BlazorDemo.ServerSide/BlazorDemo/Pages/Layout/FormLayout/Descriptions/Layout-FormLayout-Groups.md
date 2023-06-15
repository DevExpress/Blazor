A layout group ([DxFormLayoutGroup](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutGroup)) is a container for layout items ([DxFormLayoutItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutItem)) and other layout groups. Users can expand and collapse groups. Use the [ExpandButtonDisplayMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutGroup.ExpandButtonDisplayMode) property to position the group's expand button. You can apply templates to customize the group's content and appearance: [HeaderTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutGroup.HeaderTemplate), [CaptionTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutGroup.CaptionTemplate), and [HeaderContentTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutGroup.HeaderContentTemplate).

The main group properties are:
* [AnimationType](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutGroup.AnimationType) — Specifies the animation type.
* A set of [ColSpanXX](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutGroup._members) properties — Specifies the width of a group.
* [Caption](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.FormLayoutItemBase.Caption) — Specifies the group caption.
* [Enabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.FormLayoutItemBase.Enabled) — Specifies whether auto-generated editors in groups are enabled.
* [Expanded](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutGroup.Expanded) — Specifies whether the group is expanded.
* [ReadOnly](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.FormLayoutItemBase.ReadOnly) — Specifies whether the group activates read-only mode for all nested auto-generated editors.

In this demo, the template adds the **Unemployed** checkbox to a group header's content. Click this checkbox to disable group items.
