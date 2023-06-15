The group footer contains cells that correspond to data columns. To display a summary value in a group footer column, set the summary item's [FooterColumnName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridSummaryItem.FooterColumnName) to the name of this column. 

You can use the [Group Footer Display Mode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.GroupFooterDisplayMode) option to control group footer visibility: 

* [Never](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridGroupFooterDisplayMode) — Group footers are always hidden, even if they contain summary values. 
* [IfExpanded](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridGroupFooterDisplayMode) — Group footers are displayed for expanded groups only.  
* [Always](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridGroupFooterDisplayMode) — Group footers are always visible regardless of the groups' expanded state, even if they do not contain summary values. 
* [Auto](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridGroupFooterDisplayMode) — Group footers are displayed if they contain summary values and corresponding groups are expanded. Otherwise, group footers are hidden. 
