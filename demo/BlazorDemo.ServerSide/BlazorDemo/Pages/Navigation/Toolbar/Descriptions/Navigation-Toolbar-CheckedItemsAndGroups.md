A group of radio buttons allows users to select a single option from a group of options. To create a group of radio buttons within the [Toolbar](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbar), use the same [GroupName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbarItem.GroupName) property value to arrange toolbar items into a group.

Much like radio buttons, you can define separate checked buttons (with checked and unchecked state support). To create a checked button, set the [GroupName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbarItem.GroupName) property to a unique value. This changes an item's state (checked/unchecked) on every user click.

Related API members are as follows:

*   [Checked](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbarItem.Checked) — Specifies an item's checked state.
*   [CheckedChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbarItem.CheckedChanged) — Fires when an item's checked state changes.
*   [Click](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxToolbarItemBase.Click) — Fires when a user clicks the item.
