using System;
using System.Collections.Generic;

namespace BlazorDemo.Data {
    public class ChemicalElementGroup {
        readonly Lazy<List<ChemicalElementGroup>> _groups = new Lazy<List<ChemicalElementGroup>>();

        public ChemicalElementGroup(string name, List<ChemicalElementGroup> groups = null) {
            Name = name;
            if(groups != null)
                Groups.AddRange(groups);
        }

        public string Name { get; set; }

        public List<ChemicalElementGroup> Groups { get { return _groups.Value; } }
    }
}
