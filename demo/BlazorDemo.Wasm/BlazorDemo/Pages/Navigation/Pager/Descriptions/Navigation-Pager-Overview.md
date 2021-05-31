The [Pager](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPager) is a standalone UI component that enables data navigation and visualizes the current position within a bound data source. You can specify the following properties to customize the Pager:

*   [PageCount](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPager.PageCount) - The total number of pages.
*   [ActivePageIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPager.ActivePageIndex) - The zero-based index of the current page.
*   [VisibleNumericButtonCount](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPager.VisibleNumericButtonCount) - The maximum number of page numbers displayed simultaneously.

To set up how users navigate between the Pager's pages, use the [NavigationMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPager.NavigationMode) property. In **Auto** mode, the pager switches from numeric buttons to the Go to Page input box in the following situations:

*   The total number of pages is greater or equal to the [SwitchToInputBoxButtonCount](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPager.SwitchToInputBoxButtonCount) value. The default **SwitchToInputBoxButtonCount** value is 11\. If you set **PageCount** to this value (**11**), the component switches to the Go to Page input box.
*   The Pager is displayed on small devices. In this case, the [SwitchToInputBoxButtonCount](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPager.SwitchToInputBoxButtonCount) value is not taken into account.

The Pager component supports different size modes. To specify the component's size in code, use the [SizeMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPager.SizeMode) property.

Try the demo: use the drop-down list in the demo card's header to apply different size modes. To navigate between pages via two-way synchronization, use the Pager component or linked Spin Edit components.
