Use the [NavigationMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPager.NavigationMode) property to specify how users navigate between the [Pager](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPager)'s pages. The following navigation modes are available:

*   [Auto](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPager.NavigationMode) - If the number of pages is greater or equal to the [SwitchToInputBoxButtonCount](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPager.SwitchToInputBoxButtonCount) value, the component displays the Go to Page input box. Otherwise, numeric buttons are displayed.
*   [InputBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPager.NavigationMode) - Users can type a page number in the displayed Go to Page input box to jump to the corresponding page.
*   [NumericButtons](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPager.NavigationMode) - Users can click numeric buttons to navigate between pages.

In this example, the [NavigationMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPager.NavigationMode) property is set to [PagerNavigationMode.InputBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.PagerNavigationMode).
