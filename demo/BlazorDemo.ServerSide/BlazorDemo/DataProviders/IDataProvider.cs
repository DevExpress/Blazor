using System;
using System.Threading.Tasks;

namespace BlazorDemo.DataProviders {
    public interface IDataProvider {
        Task<IObservable<int>> GetLoadingStateAsync();
    }
}
