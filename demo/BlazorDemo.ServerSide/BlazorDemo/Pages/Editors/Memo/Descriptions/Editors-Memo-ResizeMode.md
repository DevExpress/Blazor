
This demo allows you to test/evaluate our Memo component's [resize modes](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMemo.ResizeMode):

* *Auto* — The Memo component changes height automatically (based on content). Users cannot resize the component.
* *Disabled* — Users cannot resize the component.
* *Horizontal* — Users can resize the component horizontally.
* *Vertical* (Default) — Users can resize the component vertically.
* *VerticalAndHorizontal* — Users can resize the component both horizontally and vertically.

Additionally, you can limit Memo height using the [MaxRows](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMemo.MaxRows) property. The property is applied when the `ResizeMode` property is set to `Auto`, `Vertical`, or `VerticalAndHorizontal`. This demo allows to evaluate the capabilities of the `MaxRows` property (for `Auto`/`Vertical`/`VerticalAndHorizontal` resize modes).
