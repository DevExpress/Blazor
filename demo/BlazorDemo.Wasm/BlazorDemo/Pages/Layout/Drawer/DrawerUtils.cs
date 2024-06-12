using System.Collections.Generic;
using DevExpress.Blazor.Internal;

namespace BlazorDemo.Pages.Layout.Drawer;

public class DrawerUtils {
    public static Dictionary<string, object> GetToolbarButtonAttributes(bool isOpen, string drawerName = null) {
        if(!string.IsNullOrEmpty(drawerName))
            drawerName += " ";
        return new Dictionary<string, object> {
            { A11yAriaAttributeUtils.AriaLabel, isOpen ? $"Close {drawerName}Drawer" : $"Open {drawerName}Drawer" },
            { A11yAriaAttributeUtils.AriaPressed, isOpen.ToString() }
        };
    }
}
