Our Blazor [DropDown](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDown) component allows you to display a drop-down window in your application. The window consists of the header, body, and footer elements. The header and footer are initially hidden. Set the [HeaderVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDown.HeaderVisible) and [FooterVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDown.FooterVisible) properties to **true** to display these elements. 

The [HeaderText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDown.HeaderText), [BodyText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDown.BodyText), and [FooterText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDown.FooterText) properties specify text displayed in the DropDown elements.

To show or close the DropDown in code, implement two-way binding for the [IsOpen](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDown.IsOpen) property. Users can click outside the DropDown's boundaries, or press Escape to close the component from the UI.