using System;
using System.Threading.Tasks;

namespace BlazorDemo.DataProviders {
    public abstract class DataProviderBase : IDataProvider  {
        static readonly Task<IObservable<int>> CompletedLoadingState = Task.FromResult<IObservable<int>>(new DataProviderLoadingState());
        public virtual Task<IObservable<int>> GetLoadingStateAsync() => CompletedLoadingState;
    }
}