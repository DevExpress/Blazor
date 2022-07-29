using System.Collections.Generic;
using System.Linq;

namespace BlazorDemo.Data {
    public class ApiMember {
        public static readonly ApiMember[] DxTreeView = new[] {
            /*BeginCollapse*/
            new ApiMember() { Name = "DxTreeView", Id = "DevExpress.Blazor.DxTreeView", Type = "container" },
            new ApiMember() { Name = "Constructors", Id = "DxTreeView.constructors", ParentId = "DevExpress.Blazor.DxTreeView", Type = "container" },
            new ApiMember() { Name = "#ctor", Id = "DevExpress.Blazor.DxTreeView.#ctor", ParentId = "DxTreeView.constructors" },
            new ApiMember() { Name = "Properties", Id = "DxTreeView.properties", ParentId = "DevExpress.Blazor.DxTreeView", Type = "container" },
            new ApiMember() { Name = "AllowSelectNodes", Id = "DevExpress.Blazor.DxTreeView.AllowSelectNodes", ParentId = "DxTreeView.properties" },
            new ApiMember() { Name = "ChildrenExpression", Id = "DevExpress.Blazor.DxTreeView.ChildrenExpression", ParentId = "DxTreeView.properties" },
            new ApiMember() { Name = "CollapseButtonIconCssClass", Id = "DevExpress.Blazor.DxTreeView.CollapseButtonIconCssClass", ParentId = "DxTreeView.properties" },
            new ApiMember() { Name = "CustomFilter", Id = "DevExpress.Blazor.DxTreeView.CustomFilter", ParentId = "DxTreeView.properties" },
            new ApiMember() { Name = "Data", Id = "DevExpress.Blazor.DxTreeView.Data", ParentId = "DxTreeView.properties" },
            new ApiMember() { Name = "DataMappings", Id = "DevExpress.Blazor.DxTreeView.DataMappings", ParentId = "DxTreeView.properties" },
            new ApiMember() { Name = "ExpandButtonIconCssClass", Id = "DevExpress.Blazor.DxTreeView.ExpandButtonIconCssClass", ParentId = "DxTreeView.properties" },
            new ApiMember() { Name = "FilterMode", Id = "DevExpress.Blazor.DxTreeView.FilterMode", ParentId = "DxTreeView.properties" },
            new ApiMember() { Name = "FilterNullText", Id = "DevExpress.Blazor.DxTreeView.FilterNullText", ParentId = "DxTreeView.properties" },
            new ApiMember() { Name = "FilterString", Id = "DevExpress.Blazor.DxTreeView.FilterString", ParentId = "DxTreeView.properties" },
            new ApiMember() { Name = "FilterMinLength", Id = "DevExpress.Blazor.DxTreeView.FilterMinLength", ParentId = "DxTreeView.properties" },
            new ApiMember() { Name = "LoadChildNodesOnDemand", Id = "DevExpress.Blazor.DxTreeView.LoadChildNodesOnDemand", ParentId = "DxTreeView.properties" },
            new ApiMember() { Name = "NodeExpandCollapseAction", Id = "DevExpress.Blazor.DxTreeView.NodeExpandCollapseAction", ParentId = "DxTreeView.properties" },
            new ApiMember() { Name = "Nodes", Id = "DevExpress.Blazor.DxTreeView.Nodes", ParentId = "DxTreeView.properties" },
            new ApiMember() { Name = "NodeTemplate", Id = "DevExpress.Blazor.DxTreeView.NodeTemplate", ParentId = "DxTreeView.properties" },
            new ApiMember() { Name = "NodeTextTemplate", Id = "DevExpress.Blazor.DxTreeView.NodeTextTemplate", ParentId = "DxTreeView.properties" },
            new ApiMember() { Name = "ShowExpandButtons", Id = "DevExpress.Blazor.DxTreeView.ShowExpandButtons", ParentId = "DxTreeView.properties" },
            new ApiMember() { Name = "ShowFilterPanel", Id = "DevExpress.Blazor.DxTreeView.ShowFilterPanel", ParentId = "DxTreeView.properties" },
            new ApiMember() { Name = "Target", Id = "DevExpress.Blazor.DxTreeView.Target", ParentId = "DxTreeView.properties" },
            new ApiMember() { Name = "Events", Id = "DxTreeView.events", ParentId = "DevExpress.Blazor.DxTreeView", Type = "container" },
            new ApiMember() { Name = "AfterCollapse", Id = "DevExpress.Blazor.DxTreeView.AfterCollapse", ParentId = "DxTreeView.events" },
            new ApiMember() { Name = "AfterExpand", Id = "DevExpress.Blazor.DxTreeView.AfterExpand", ParentId = "DxTreeView.events" },
            new ApiMember() { Name = "BeforeCollapse", Id = "DevExpress.Blazor.DxTreeView.BeforeCollapse", ParentId = "DxTreeView.events" },
            new ApiMember() { Name = "BeforeExpand", Id = "DevExpress.Blazor.DxTreeView.BeforeExpand", ParentId = "DxTreeView.events" },
            new ApiMember() { Name = "FilterStringChanged", Id = "DevExpress.Blazor.DxTreeView.FilterStringChanged", ParentId = "DxTreeView.events" },
            new ApiMember() { Name = "SelectionChanged", Id = "DevExpress.Blazor.DxTreeView.SelectionChanged", ParentId = "DxTreeView.events" },
            new ApiMember() { Name = "Methods", Id = "DxTreeView.methods", ParentId = "DevExpress.Blazor.DxTreeView", Type = "container" },
            new ApiMember() { Name = "ClearSelection", Id = "DevExpress.Blazor.DxTreeView.ClearSelection", ParentId = "DxTreeView.methods" },
            new ApiMember() { Name = "CollapseAll", Id = "DevExpress.Blazor.DxTreeView.CollapseAll", ParentId = "DxTreeView.methods" },
            new ApiMember() { Name = "ExpandAll", Id = "DevExpress.Blazor.DxTreeView.ExpandAll", ParentId = "DxTreeView.methods" },
            new ApiMember() { Name = "ExpandToNode", Id = "DevExpress.Blazor.DxTreeView.ExpandToNode(System.Func{DevExpress.Blazor.ITreeViewNodeInfo,System.Boolean})", ParentId = "DxTreeView.methods" },
            new ApiMember() { Name = "GetNodeExpanded", Id = "DevExpress.Blazor.DxTreeView.GetNodeExpanded(System.Func{DevExpress.Blazor.ITreeViewNodeInfo,System.Boolean})", ParentId = "DxTreeView.methods" },
            new ApiMember() { Name = "GetNodeInfo", Id = "DevExpress.Blazor.DxTreeView.GetNodeInfo(System.Func{DevExpress.Blazor.ITreeViewNodeInfo,System.Boolean})", ParentId = "DxTreeView.methods" },
            new ApiMember() { Name = "GetNodesInfo", Id = "DevExpress.Blazor.DxTreeView.GetNodesInfo(System.Func{DevExpress.Blazor.ITreeViewNodeInfo,System.Boolean})", ParentId = "DxTreeView.methods" },
            new ApiMember() { Name = "GetSelectedNodeInfo", Id = "DevExpress.Blazor.DxTreeView.GetSelectedNodeInfo", ParentId = "DxTreeView.methods" },
            new ApiMember() { Name = "SelectNode", Id = "DevExpress.Blazor.DxTreeView.SelectNode(System.Func{DevExpress.Blazor.ITreeViewNodeInfo,System.Boolean})", ParentId = "DxTreeView.methods" },
            new ApiMember() { Name = "SetNodeExpanded", Id = "DevExpress.Blazor.DxTreeView.SetNodeExpanded(System.Func{DevExpress.Blazor.ITreeViewNodeInfo,System.Boolean},System.Boolean)", ParentId = "DxTreeView.methods" },
            /*EndCollapse*/
        };

        public static readonly ApiMember[] DxContextMenu = new[] {
            /*BeginCollapse*/
            new ApiMember() { Name = "DxContextMenu", Id = "DevExpress.Blazor.DxContextMenu", Type = "container" },
            new ApiMember() { Name = "Constructors", Id = "DxContextMenu.constructors", ParentId = "DevExpress.Blazor.DxContextMenu", Type = "container" },
            new ApiMember() { Name = "#ctor", Id = "DevExpress.Blazor.DxContextMenu.#ctor", ParentId = "DxContextMenu.constructors" },
            new ApiMember() { Name = "Properties", Id = "DxContextMenu.properties", ParentId = "DevExpress.Blazor.DxContextMenu", Type = "container" },
            new ApiMember() { Name = "Events", Id = "DxContextMenu.events", ParentId = "DevExpress.Blazor.DxContextMenu", Type = "container" },
            new ApiMember() { Name = "Methods", Id = "methods", ParentId = "DevExpress.Blazor.DxContextMenu", Type = "container" },
            new ApiMember() { Name = "Data", Id = "DevExpress.Blazor.DxContextMenu.Data", ParentId = "DxContextMenu.properties" },
            new ApiMember() { Name = "DataMappings", Id = "DevExpress.Blazor.DxContextMenu.DataMappings", ParentId = "DxContextMenu.properties" },
            new ApiMember() { Name = "Enabled", Id = "DevExpress.Blazor.DxContextMenu.Enabled", ParentId = "DxContextMenu.properties" },
            new ApiMember() { Name = "Items", Id = "DevExpress.Blazor.DxContextMenu.Items", ParentId = "DxContextMenu.properties" },
            new ApiMember() { Name = "ItemTemplate", Id = "DevExpress.Blazor.DxContextMenu.ItemTemplate", ParentId = "DxContextMenu.properties" },
            new ApiMember() { Name = "ItemTextTemplate", Id = "DevExpress.Blazor.DxContextMenu.ItemTextTemplate", ParentId = "DxContextMenu.properties" },
            new ApiMember() { Name = "SubMenuTemplate", Id = "DevExpress.Blazor.DxContextMenu.SubMenuTemplate", ParentId = "DxContextMenu.properties" },
            new ApiMember() { Name = "Hidden", Id = "DevExpress.Blazor.DxContextMenu.Hidden", ParentId = "DxContextMenu.events" },
            new ApiMember() { Name = "ItemClick", Id = "DevExpress.Blazor.DxContextMenu.ItemClick", ParentId = "DxContextMenu.events" },
            new ApiMember() { Name = "Shown", Id = "DevExpress.Blazor.DxContextMenu.Shown", ParentId = "DxContextMenu.events" },
            new ApiMember() { Name = "HideAsync", Id = "DevExpress.Blazor.DxContextMenu.HideAsync", ParentId = "methods" },
            new ApiMember() { Name = "ShowAsync(MouseEventArgs)", Id = "DevExpress.Blazor.DxContextMenu.ShowAsync(Microsoft.AspNetCore.Components.Web.MouseEventArgs)", ParentId = "methods" },
            new ApiMember() { Name = "ShowAsync(Double, Double)", Id = "DevExpress.Blazor.DxContextMenu.ShowAsync(System.Double, System.Double)", ParentId = "methods" },
            /*EndCollapse*/
        };

        public static readonly ApiMember[] DxMenu = new[] {
            /*BeginCollapse*/
            new ApiMember() { Name = "DxMenu", Id = "DevExpress.Blazor.DxMenu", Type = "container" },
            new ApiMember() { Name = "Constructors", Id = "DxMenu.constructors", ParentId = "DevExpress.Blazor.DxMenu", Type = "container" },
            new ApiMember() { Name = "#ctor", Id = "DevExpress.Blazor.DxMenu.#ctor", ParentId = "DxMenu.constructors" },
            new ApiMember() { Name = "Properties", Id = "DxMenu.properties", ParentId = "DevExpress.Blazor.DxMenu", Type = "container" },
            new ApiMember() { Name = "Events", Id = "DxMenu.events", ParentId = "DevExpress.Blazor.DxMenu", Type = "container" },
            new ApiMember() { Name = "CloseMenuOnItemClick", Id = "DevExpress.Blazor.DxMenu.CloseMenuOnItemClick", ParentId = "DxMenu.properties" },
            new ApiMember() { Name = "CollapseItemsToHamburgerMenu", Id = "DevExpress.Blazor.DxMenu.CollapseItemsToHamburgerMenu", ParentId = "DxMenu.properties" },
            new ApiMember() { Name = "CollapseItemToIconMode", Id = "DevExpress.Blazor.DxMenu.CollapseItemToIconMode", ParentId = "DxMenu.properties" },
            new ApiMember() { Name = "Data", Id = "DevExpress.Blazor.DxMenu.Data", ParentId = "DxMenu.properties" },
            new ApiMember() { Name = "DataMappings", Id = "DevExpress.Blazor.DxMenu.DataMappings", ParentId = "DxMenu.properties" },
            new ApiMember() { Name = "DisplayMode", Id = "DevExpress.Blazor.DxMenu.DisplayMode", ParentId = "DxMenu.properties" },
            new ApiMember() { Name = "DropDownActionMode", Id = "DevExpress.Blazor.DxMenu.DropDownActionMode", ParentId = "DxMenu.properties" },
            new ApiMember() { Name = "HamburgerButtonPosition", Id = "DevExpress.Blazor.DxMenu.HamburgerButtonPosition", ParentId = "DxMenu.properties" },
            new ApiMember() { Name = "HamburgerIconCssClass", Id = "DevExpress.Blazor.DxMenu.HamburgerIconCssClass", ParentId = "DxMenu.properties" },
            new ApiMember() { Name = "Items", Id = "DevExpress.Blazor.DxMenu.Items", ParentId = "DxMenu.properties" },
            new ApiMember() { Name = "ItemsPosition", Id = "DevExpress.Blazor.DxMenu.ItemsPosition", ParentId = "DxMenu.properties" },
            new ApiMember() { Name = "ItemsStretched", Id = "DevExpress.Blazor.DxMenu.ItemsStretched", ParentId = "DxMenu.properties" },
            new ApiMember() { Name = "ItemTemplate", Id = "DevExpress.Blazor.DxMenu.ItemTemplate", ParentId = "DxMenu.properties" },
            new ApiMember() { Name = "ItemTextTemplate", Id = "DevExpress.Blazor.DxMenu.ItemTextTemplate", ParentId = "DxMenu.properties" },
            new ApiMember() { Name = "Orientation", Id = "DevExpress.Blazor.DxMenu.Orientation", ParentId = "DxMenu.properties" },
            new ApiMember() { Name = "SubMenuTemplate", Id = "DevExpress.Blazor.DxMenu.SubMenuTemplate", ParentId = "DxMenu.properties" },
            new ApiMember() { Name = "Title", Id = "DevExpress.Blazor.DxMenu.Title", ParentId = "DxMenu.properties" },
            new ApiMember() { Name = "TitleTemplate", Id = "DevExpress.Blazor.DxMenu.TitleTemplate", ParentId = "DxMenu.properties" },
            new ApiMember() { Name = "ItemClick", Id = "DevExpress.Blazor.DxMenu.ItemClick", ParentId = "DxMenu.events" },            
            /*EndCollapse*/
        };

        public static readonly ApiMember[] NavigationApi = DxContextMenu.Concat(DxMenu).Concat(DxTreeView).ToArray();

        public string Id { get; set; }
        public string CssClass => "itemclass";
        public string ParentId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string NavigateUrl => GetNavigateUrl();
        string GetNavigateUrl() /*BeginHide*/ {
            if(Type == "container" || Id == null)
                return null;
            return "https://docs.devexpress.com/blazor/"
                   + Id.Replace(',', '-').Replace('{', '-').Replace('}', '-').Replace("--", "-");
        }
        /*EndHide*/
    }
}
