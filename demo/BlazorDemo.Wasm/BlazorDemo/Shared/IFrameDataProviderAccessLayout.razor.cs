using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemo.DataProviders;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Shared {
    public partial class IFrameDataProviderAccessLayout<T> where T : IDataProvider {
        [Inject] T DataProvider { get; set; }
        protected virtual IEnumerable<IDataProvider> GetDataProviders() {
            yield return DataProvider;
        }
    }
}

