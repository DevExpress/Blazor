using System;
using System.Collections.Generic;
using BlazorDemo.Data;
namespace BlazorDemo.Pages.TreeList {
    public static class TreeListRenderHelper {
        public static IEnumerable<string> SpaceObjectTypes { get; } = new[] {
            "Star",
            "Planet",
            "Dwarf planet",
            "Satellite",
            "Asteroid"
        };
    }
}
