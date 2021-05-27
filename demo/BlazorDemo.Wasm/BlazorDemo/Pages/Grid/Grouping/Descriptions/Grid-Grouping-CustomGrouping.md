Follow the steps below to implement custom logic used to group data in the Blazor Grid.  

1. Set the [DxGridColumn.GroupInterval](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridColumn.GroupInterval) property to `GridColumnGroupInterval.Custom`. 
2. Handle the [DxGrid.CustomGroup](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomGroup) event to implement your logic. You should compare column values and define whether these values belong to the same group. Use the [GridCustomGroupEventArgs](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridCustomGroupEventArgs) event arguments (`Value1`, `Value2`, `SameGroup`, etc.) to access column values and compare them. 
   
   You can also handle the [CustomizeGroupValueDisplayText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomizeGroupValueDisplayText) event to customize text for group rows. 

In this demo, custom group logic is implemented for the **Unit Price** column. Data are grouped for the following intervals: $0.00 - $10.00, $10.00 - $20.00, etc.  
