using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemo.DemoData {
    public class DemoItemBase {
        public string Title { get; set; }
        public virtual IEnumerable<DemoItem> GetNavTreeChildren(bool demoMode) { return Enumerable.Empty<DemoItem>(); }
    }
}
