using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Configuration;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemo.DataProviders {
    public abstract class DataProviderBase : IDataProvider {
        static readonly Task<IObservable<int>> CompletedLoadingState = Task.FromResult<IObservable<int>>(new DataProviderLoadingState());
        public virtual Task<IObservable<int>> GetLoadingStateAsync() => CompletedLoadingState;
    }
}
