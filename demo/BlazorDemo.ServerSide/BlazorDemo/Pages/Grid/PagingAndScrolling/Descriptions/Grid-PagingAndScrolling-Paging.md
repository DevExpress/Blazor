The DevExpress Blazor [Grid](https://docs.devexpress.com/Blazor/403143/grid) can split data rows across multiple pages and displays a pager to enable data navigation between pages. Use the [PagerNavigationMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.PagerNavigationMode) property to specify how users navigate among pages. The following values are available:

* `InputBox` — The pager includes an input box. Users can enter the desired page value within it.
* `NumericButtons` — The pager includes numeric buttons.
* `Auto` (default) — If the number of pages is greater than or equal to the [PagerSwitchToInputBoxButtonCount](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.PagerSwitchToInputBoxButtonCount) value or the Grid is displayed on small devices, the pager displays an input box. Otherwise, numeric buttons are displayed.

The Grid also includes the following paging-related customization options:
* [PageSize](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.PageSize) — Specifies the maximum number of rows displayed on a page.
* [PageIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.PageIndex) — Specifies the current page index.
* [PagerPosition](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.PagerPosition) — Specifies pager position (at the bottom, at the top, or both at the bottom and the top).
* [PagerVisibleNumericButtonCount](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.PagerVisibleNumericButtonCount) — Specifies the maximum number of numeric buttons displayed in the pager.
* [PagerAutoHideNavButtons](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.PagerAutoHideNavButtons) — Specifies whether the pager's arrow navigation buttons are hidden when all numeric buttons are displayed.
* [PagerVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.PagerVisible) — Specifies whether the Grid displays the pager.

Our Blazor Grid also allows users to change the page size dynamically at runtime. To display the page size selector, enable the [PageSizeSelectorVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.PageSizeSelectorVisible) option. Use the [PageSizeSelectorItems](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.PageSizeSelectorItems) property to specify predefined page sizes (available in a drop-down list). You can also enable the [PageSizeSelectorAllRowsItemVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.PageSizeSelectorAllRowsItemVisible) option to display all Grid rows on one page (the **All** dropdown item).

The Grid displays a vertical/horizontal scrollbar when content height/width exceeds the size of the component itself.

In this demo, the Grid contains 20 rows on a page (the [PageSize](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.PageSize) property is set to `20`), but overall Grid height is limited by a CSS rule.


