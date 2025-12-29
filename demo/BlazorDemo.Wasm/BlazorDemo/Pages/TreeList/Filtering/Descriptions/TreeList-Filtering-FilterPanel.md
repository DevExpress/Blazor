The DevExpress Blazor TreeList component ships with an integrated Filter Panel. This panel includes the following UI elements:

- A filter toggle — Allows you to temporarily deactivate the filter.
- Current filter condition — Click it to open the Filter Builder dialog and customize the filter condition.
- Clear Filter button

Our Blazor TreeList automatically synchronizes filter changes across all filter elements. Try and customize the filter condition using the Filter Builder or Column Filter Menus. Note how our TreeList component immediately updates the Filter Panel.

Use the [`FilterPanelDisplayMode`](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.FilterPanelDisplayMode) option to control panel visibility:

- `Never` (Default) — The Filter Panel is hidden.
- `Always` — The Filter Panel is always visible.
- `Auto` — The Filter Panel appears when data is filtered (otherwise, the panel is hidden).

The [FilterTreeMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.FilterTreeMode) property specifies whether the TreeList component displays child/parent records for rows that meet filter criteria. Select the **Display Nodes** option to try different filter modes.
