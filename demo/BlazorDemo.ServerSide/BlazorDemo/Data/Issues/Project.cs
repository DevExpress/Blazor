using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace BlazorDemo.Data.Issues {
    [Guid("AC2E2606-022C-4A4E-9F25-7481F0879BBC")]
    public partial class Project {
        public long ID { get; set; }
        public string Name { get; set; }
        public Nullable<long> ManagerID { get; set; }
    }
}
