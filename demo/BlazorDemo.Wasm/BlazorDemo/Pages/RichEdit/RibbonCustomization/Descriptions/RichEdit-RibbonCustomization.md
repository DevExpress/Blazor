The [CustomizeRibbon](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit.CustomizeRibbon) event allows you to access and customize our Blazor [Rich Text Editor](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit)'s Ribbon. The [Ribbon](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Office.IRibbon) consists of multiple [tabs](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Office.IRibbonTab) and each tab includes at least one [group](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Office.IBarGroup). A group can contain multiple [items](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Office.IBarItem) ([bar item type](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Office.BarItemTypes)).

In this demo, we've customized our Rich Text Editor's [Ribbon](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Office.IRibbon) in the following manner:

* Removed built-in *Design* and *Layout* [contextual](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.RichEditRibbonContextTabType) tabs from the Ribbon
* Created a custom *Table Tools* contextual tab and added this tab to the Ribbon
* Removed the *Open Document* item from the *File* tab
* Removed the *Arial* and *Arial Black* [subitems](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Office.IBarComboBox.Items) from the *Font Name* [combo box](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Office.IBarComboBox) item
* Customized the behavior of the *Insert Page Header* [button](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Office.IBarButton) and *Insert Field Menu* [drop down](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Office.IBarDropDown) items
