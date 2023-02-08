A toolbar item displays a drop-down list if you populate the [DxToolbarItem.Items](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbarItem.Items) collection. The drop-down list can be displayed as a standard sub-menu, as a modal dialog, or as a modal bottom sheet. You can specify its type explicitly or allow the component to adapt to the device type. To specify the display mode, use the following properties:

*   [DxToolbarBase.DropDownDisplayMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbar.DropDownDisplayMode) - Applies to all menus in the toolbar.
*   [DxToolbarItemBase.DropDownDisplayMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxToolbarItemBase.DropDownDisplayMode) - Applies to an individual item.

You can turn a parent toolbar item into a split button (where its drop-down action is segregated from the primary click region). To enable this behavior, set the [SplitDropDownButton](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbarItem.SplitDropDownButton) property to `true`.
