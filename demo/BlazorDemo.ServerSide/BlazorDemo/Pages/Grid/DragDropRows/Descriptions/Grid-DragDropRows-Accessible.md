This demo illustrates accessibility-related capabilities of the DevExpress Blazor Grid. Specifically, it illustrates how end-users can initiate drag & drop operations within the Grid using the keyboard. You can use the following key combinations to initiate drag & drop operations:

- Tab, Shift+Tab, Arrows: to navigate between Grid cells (navigation buttons in the last three columns).
- Enter:  to use buttons that reorder rows or move them between Grid components.
- Ctrl+Up Arrow, Ctrl+Down Arrow: to move focus between navigation areas/Grids.
- Escape - to exit the nested navigation object (in this demo, navigation buttons).

Note: Demo code processes keyboard shortcuts and move rows. When users initiate drag operations with the mouse, changes are processed in the [ItemsDropped](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ItemsDropped) event handler.
