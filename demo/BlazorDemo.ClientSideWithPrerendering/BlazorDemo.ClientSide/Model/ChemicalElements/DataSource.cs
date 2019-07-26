using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Blazor.Model {
    public static class ChemicalElements {
        private static readonly Lazy<List<ChemicalElementGroup>> chemicalElementGroups = new Lazy<List<ChemicalElementGroup>>(() => {
            List<ChemicalElementGroup> groups = new List<ChemicalElementGroup>() {
                new ChemicalElementGroup("Metals", new List<ChemicalElementGroup>() {
                    new ChemicalElementGroup("Alkali metals"),
                    new ChemicalElementGroup("Alkaline earth metals"),
                    new ChemicalElementGroup("Inner transition elements", new List<ChemicalElementGroup>() {
                        new ChemicalElementGroup("Lanthanides"),
                        new ChemicalElementGroup("Actinides")
                    }),
                    new ChemicalElementGroup("Transition elements"),
                    new ChemicalElementGroup("Other metals")
                }),
                new ChemicalElementGroup("Metalloids"),
                new ChemicalElementGroup("Nonmetals", new List<ChemicalElementGroup>() {
                    new ChemicalElementGroup("Halogens"),
                    new ChemicalElementGroup("Noble gases"),
                    new ChemicalElementGroup("Other nonmetals")
                })
            };
            return groups;
        });

        public static List<ChemicalElementGroup> Groups { get { return chemicalElementGroups.Value; } }
    }
}
