DevExpress Blazor Chart components allow you to display and configure [annotations](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAnnotationBase-1) (comments about chart content). DevExpress Chart components support text and image annotations. These annotations can be anchored to chart elements or remain unanchored (positioned with X and Y coordinates).
 
To create an annotation, you must:
1. Add an appropriate annotation object to chart markup ([DxChartAnnotation](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAnnotation) for [DxChart](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1), [DxPieChartAnnotation](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPieChartAnnotation) for [DxPieChart](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPieChart-1)).
2. Specify annotation [type](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAnnotationBase-1#type) and [location](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAnnotationBase-1#location).
3. *Optional*. Customize annotation [size](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAnnotationBase-1#size) and [appearance](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAnnotationBase-1#appearance-customization), and configure [tooltips](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAnnotationBase-1#tooltips).
 
Note the customized annotations (with tooltips) used in this demo: four text annotations anchored to series points and one draggable image annotation positioned with pixel coordinates.
