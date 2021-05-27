The Menu component supports different display modes (the [DisplayMode]( https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMenu.DisplayMode) property):

*   **Auto** - the menu is adapted to the device type.

*   **Desktop** - the menu is shown as a panel with root items. The menu view also depends on the [orientation]( https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMenu.Orientation). In the horizontal orientation, child items are available in drop-down menus. In the vertical orientation, submenus with child items are shown to the side of the menu container.

*   **Mobile** - the menu has a compact view and depends on the [orientation]( https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMenu.Orientation). In the horizontal orientation, it is a hamburger menu. In the vertical orientation, the menu looks like a desktop menu - a panel with root items, but submenus are shown in the main menu container and have the Back button.

This demo demonstrates how to create a horizontal menu for mobile devices.
