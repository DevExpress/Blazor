The Color Palette component allows you to use predefined sets of colors (**presets**). The following presets are available:

* Universal 
* Universal Gradient 
* Fluent Theme 
* Fluent Theme Gradient	 
* Pastel
* Pastel Gradient 
* Warm 
* Warm Gradient 
* Cold 
* Cold Gradient 
* Standard

This demo displays the Color Palette with all available presets.

To add multiple color groups to the palette, you must:

1. Add `<Groups>...</Groups>` to the component's markup to define the [Groups](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxColorPalette.Groups) collection.
2. Add [DxColorPaletteGroup](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxColorPaletteGroup) objects to the collection. Use the [Colors](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxColorPaletteGroup.Colors) property to specify a [palette preset](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxColorPalette#palette-presets) or add [custom colors](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxColorPalette#custom-colors) to the palette.
