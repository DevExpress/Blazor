using System;
using System.Collections.Generic;

namespace Demo.Blazor.Model {
    public partial class Area {
        public Area() {
            Rentinfo = new HashSet<Rentinfo>();
        }

        public Guid Oid { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Area1 { get; set; }
        public string Name { get; set; }
        public int Population2000 { get; set; }
        public int Population2010 { get; set; }

        public virtual ICollection<Rentinfo> Rentinfo { get; set; }
    }
}
