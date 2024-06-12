You can use the [DxLayoutBreakpoint](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxLayoutBreakpoint) component to adapt a grid layout to different screen sizes.

The code below does the following:

*   Creates an **isXSmallScreen** data field.
*   Adds a **DxGridLayout** component, uses named areas to arrange items, and adapts the layout for different screen sizes depending on the **isXSmallScreen** field value.
*   Adds a **DxLayoutBreakpoint** component. The [DeviceSize](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxLayoutBreakpoint.DeviceSize) property specifies the device size when the breakpoint should be activated. The [IsActive](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxLayoutBreakpoint.IsActive) property is bound to the **isXSmallScreen** field. When the breakpoint is activated, the **IsActive** property and the bound **IsXSmallScreen** field equal **true**.
