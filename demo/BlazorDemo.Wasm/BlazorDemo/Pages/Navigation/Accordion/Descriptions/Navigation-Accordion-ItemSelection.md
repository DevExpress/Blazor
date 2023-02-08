Our Blazor Accordion component allows users to select a single item. The selected item is highlighted automatically.

To select an Accordion item, use one of the following options:  

* Click an item header to select the corresponding item; 
* Call the [SelectItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxAccordion.SelectItem(System.Func-DevExpress.Blazor.IAccordionItemInfo-System.Boolean-)) method to select an item in code; 
* The component can automatically select an item based on the item's [NavigateUrl](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxAccordionItem.NavigateUrl) property and the current browser URL. Use the [UrlMatchMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxAccordion.UrlMatchMode) property to enable this capability.  

To force the Accordion to select a single item, set the [SelectionMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxAccordion.SelectionMode) property to `Single`. You can also use the [DxAccordionItem.AllowSelection](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxAccordionItem.AllowSelection) property in unbound mode and the [DxAccordionDataMappingBase.AllowSelection](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxAccordionDataMappingBase.AllowSelection) property in bound mode to prevent users from selecting specific items. Handle the [SelectionChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxAccordion.SelectionChanged) event to react to selection changes. Call the [ClearSelection()](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxAccordion.ClearSelection) method to deselect items.
