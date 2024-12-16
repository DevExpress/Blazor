The DevExpress Blazor TreeList can split data into pages and display a built-in navigation control (a TreeList Pager). A vertical/horizontal scrollbar also appears if content height/width exceed component size.

Use the [PagerNavigationMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.PagerNavigationMode) property to specify navigation between pages. The following values are available:

* `InputBox` — The pager displays an input box. Users can enter the desired page number.
* `NumericButtons` — The pager displays numeric buttons.
* `Auto` (default) — If the number of pages exceeds a predefined limit ([PagerSwitchToInputBoxButtonCount](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.PagerSwitchToInputBoxButtonCount)) or the TreeList is displayed on a small device, the pager displays an input box. Otherwise, numeric buttons are displayed.

The TreeList also includes the following paging-related customization options:
* [PageSize](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.PageSize) — Specifies the maximum number of rows displayed on a page.
* [PageIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.PageIndex) — Specifies the current page index.
* [PagerPosition](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.PagerPosition) — Specifies pager position (at the top, at the bottom, or both).
* [PagerVisibleNumericButtonCount](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.PagerVisibleNumericButtonCount) — Specifies the maximum number of numeric buttons displayed in the pager.
* [PagerAutoHideNavButtons](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.PagerAutoHideNavButtons) — Specifies whether the pager's arrow navigation buttons are hidden when all numeric buttons are displayed.
* [PagerVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.PagerVisible) — Specifies whether the TreeList displays the pager.

Our Blazor TreeList also allows users to change page size dynamically at runtime. To display the page size selector, enable the [PageSizeSelectorVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.PageSizeSelectorVisible) option. Use the [PageSizeSelectorItems](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.PageSizeSelectorItems) property to specify predefined page sizes (available in a drop-down list). You can also enable the [PageSizeSelectorAllRowsItemVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.PageSizeSelectorAllRowsItemVisible) option to display all TreeList rows on one page (the **All** dropdown item).

In this demo, the TreeList component displays the page size selector, with an **All** item. The **Pager position** option allows you to modify pager position. You can use keyboard shortcuts to navigate between pages. Focus the pager area and press the Left Arrow/Right Arrow to go to the previous/next page. To open the first/last page, focus the pager area and press Home/End.
