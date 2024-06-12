using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface ISpaceObjectDataProvider {
        public List<SpaceObject> GenerateData();
    }
}
