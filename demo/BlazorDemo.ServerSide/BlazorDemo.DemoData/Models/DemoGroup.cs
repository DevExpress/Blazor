using System.Text.Json.Serialization;

namespace BlazorDemo.DemoData {
    public class DemoGroup : DemoItemBase {
        public string NavigationAriaLabel { get; set; }
        public DemoPage[] Pages { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public GroupCategory Category { get; set; }
        public override IEnumerable<DemoItem> GetNavTreeChildren(bool demoMode) {
            return Pages.Where(p => p.IsNavTreeVisible(demoMode));
        }
    }

    public enum GroupCategory {
        Default,
        Reports
    }
}
