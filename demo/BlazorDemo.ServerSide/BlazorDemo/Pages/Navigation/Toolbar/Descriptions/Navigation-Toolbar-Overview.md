The [Toolbar](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbar) component allows you to implement an adaptive button-based interface within your Blazor application. Toolbar buttons are stored in the [Items](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbar.Items) collection, and each button is defined by a [DxToolbarItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbarItem) object (which can display an icon, text or both).

Key Toolbar API members are as follows:

*   [Click](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxToolbarItemBase.Click) - Fires when users click the toolbar item. Handle this event to specify different click handlers for different items. To specify a common click handler for all toolbar items, use the Toolbar's [ItemClick](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbar.ItemClick) event.
*   [Text](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxToolbarItemBase.Text) - Specifies item text.
*   [BeginGroup](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxToolbarItemBase.BeginGroup) - Set to `true` to create a new item group.
*   [IconCssClass](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxToolbarItemBase.IconCssClass) - Specifies the name of the CSS class applied to a toolbar item's icon.
*   [NavigateUrl](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbarItem.NavigateUrl) - Specifies the item's navigation URL. When this property is specified, the button is rendered as a hyperlink.
*   [Target](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbarItem.Target) - Specifies [target](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/A#attr-target) attribute value for an item.
*   [Alignment](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxToolbarItemBase.Alignment) - Specifies item alignment.
*   [Enabled](https://docs.devexpress.devx/Blazor/DevExpress.Blazor.Base.DxNavigationControlComponent-2.Enabled) - Specifies whether the component is enabled.
