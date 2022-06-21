The [Toolbar](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbar) component allows you to implement an adaptive button-based interface in your Blazor application. Toolbar buttons are stored in the [Items](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbar.Items) collection, and each button is represented by a [DxToolbarItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbarItem) object that can display an icon, text or both.

The main Toolbar item's API members are listed below:

*   [Click](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxToolbarItemBase.Click) - Fires when users click the toolbar item. Handle this event to specify different click handlers for different items. To specify a common click handler for all toolbar items, use the Toolbar's [ItemClick](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbar.ItemClick) event.
*   [Text](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxToolbarItemBase.Text) - Specifies the item's text.
*   [BeginGroup](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxToolbarItemBase.BeginGroup) - Set this property to true to create a new item group.
*   [IconCssClass](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxToolbarItemBase.IconCssClass) - Specifies the name of the CSS class applied to the toolbar item's icon.
*   [NavigateUrl](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbarItem.NavigateUrl) - Specifies the item's navigation URL. When this property is specified, the button is rendered as a hyperlink.
*   [Alignment](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxToolbarItemBase.Alignment) - Specifies the item's alignment.
