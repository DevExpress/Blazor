The DevExpress Blazor [Filter Builder](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFilterBuilder) supports operator customization. Specify the [GroupOperatorTypes](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFilterBuilder.GroupOperatorTypes) property to limit available logical operators (used to combine filter conditions).

Use the [CustomizeOperators](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFilterBuilder.CustomizeOperators) event to customize filter operators (used to build filter conditions):

- Manage built-in operator collections
- Add custom criteria functions
- Arrange operators into groups
- Assign operators used by default for each data type
- Customize operator captions and icons

This demo limits built-in filter operators used for **Product Name** and **Country** fields. You can also click checkboxes to display or hide inverse logical operators, custom functions, and operator groups.

Refer to the following topic for additional information: [Filter Operators](https://docs.devexpress.com/Blazor/405616/components/filter-builder/operators).
