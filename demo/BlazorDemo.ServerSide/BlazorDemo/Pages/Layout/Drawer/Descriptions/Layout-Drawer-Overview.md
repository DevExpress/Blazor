The DevExpress [Drawer](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDrawer) for Blazor allows you to add a side panel to your application. Use this panel to host navigation UI elements or display additional information about the current view.

The component consists of a drawer panel and target content area. To implement site navigation, place a navigation control inside the panel ([BodyTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDrawer.BodyTemplate)) and populate the target content area ([TargetContent](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDrawer.TargetContent)).

[HeaderTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDrawer.HeaderTemplate) and [FooterTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDrawer.FooterTemplate) properties allow you populate footer and header areas with additional elements.

To display or close the Drawer in code, implement two-way binding for the [IsOpen](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDrawer.IsOpen) property.
