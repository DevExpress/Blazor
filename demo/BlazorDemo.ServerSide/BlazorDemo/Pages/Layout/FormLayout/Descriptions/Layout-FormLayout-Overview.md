The DevExpress Blazor [Form Layout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayout) component allows you to construct responsive and auto-aligned edit forms.

The component uses a responsive grid system based on the [CSS flexible box layout](https://developer.mozilla.org/en-US/docs/Web/CSS/Guides/Flexible_box_layout) to render its items. Each layout item can occupy between 1 and 12 columns. This value can be defined separately for six different screen resolution types as listed below:

1.  [ColSpanXxl](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.FormLayoutItemBase.ColSpanXxl): Screens that are 1400px or wider.
2.  [ColSpanXl](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.FormLayoutItemBase.ColSpanXl): Screens that are 1200px or wider.
3.  [ColSpanLg](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.FormLayoutItemBase.ColSpanLg):  Screens that are 992px or wider.
4.  [ColSpanMd](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.FormLayoutItemBase.ColSpanMd): Screens that are 768px or wider.
5.  [ColSpanSm](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.FormLayoutItemBase.ColSpanSm): Screens that are 576px or wider.
6.  [ColSpanXs](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.FormLayoutItemBase.ColSpanXs): Screens that are less than 576px.

Form Layout items support different size modes. To specify component size in code, use the [SizeMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayout.SizeMode) property. To apply different size modes in the demo, use the drop-down list in the demo card's header.

In this demo, the [CaptionTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutItem.CaptionTemplate) property specifies custom content for the **Email** item's caption. The template contains a button that when clicked, displays clarification information.

The Form Layout component also supports keyboard navigation. Press the Tab key or Shift+Tab to navigate through Form Layout items.