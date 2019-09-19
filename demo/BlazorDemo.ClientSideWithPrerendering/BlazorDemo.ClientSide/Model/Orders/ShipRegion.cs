using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Blazor.Model {
    public static class ShipRegionRepository {
        public static IList<ShipRegion> ShipRegions;

        static ShipRegionRepository() {
            ShipRegions = new List<ShipRegion>() {
                new ShipRegion() { RegionID = 1, Name = "North America" },
                new ShipRegion() { RegionID = 2, Name = "Europe, Middle East, Africa" },
                new ShipRegion() { RegionID = 3, Name = "Asia/Pacific" },
            };
        }
        public static Task<IEnumerable<ShipRegion>> Load() { 
            return Task.FromResult<IEnumerable<ShipRegion>>(ShipRegions);
        }
    }
}
