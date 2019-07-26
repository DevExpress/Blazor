using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Blazor.Model {
    public class ChemicalElementGroup { 
        Lazy<List<ChemicalElementGroup>> groups = new Lazy<List<ChemicalElementGroup>>();

        public ChemicalElementGroup(string name, List<ChemicalElementGroup> groups = null) {
            Name = name;
            if (groups != null)
                Groups.AddRange(groups);
        }

        public string Name { get; set; }

        public List<ChemicalElementGroup> Groups { get { return groups.Value; } }
    }
}
