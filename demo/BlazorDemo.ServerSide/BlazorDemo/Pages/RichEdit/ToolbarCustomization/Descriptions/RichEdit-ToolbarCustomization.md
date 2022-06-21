If you prefer the use of a Toolbar versus a Ribbon, set the [BarMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit.BarMode) property to `Toolbar`. Handle the [CustomizeToolbar](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit.CustomizeToolbar) event to access and customize the Rich Text Editor's built-in toolbar.

A [toolbar](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Office.IToolbar) consists of [groups](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Office.IBarGroup) that contain various [item](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Office.IBarItem) types. Call one of the following method overloads to create a custom item and add it to a toolbar group:

* [AddCustomButton](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Office.BarItemCollection.AddCustomButton.overloads)
* [AddCustomCheckButton](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Office.BarItemCollection.AddCustomCheckButton.overloads)
* [AddCustomColorEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Office.BarItemCollection.AddCustomColorEdit.overloads)
* [AddCustomComboBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Office.BarItemCollection.AddCustomComboBox.overloads)
* [AddCustomDropDown](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Office.BarItemCollection.AddCustomDropDown.overloads) 
* [AddCustomSpinEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Office.BarItemCollection.AddCustomSpinEdit.overloads)

This demo illustrates how you can populate a toolbar with built-in and/or custom items.
