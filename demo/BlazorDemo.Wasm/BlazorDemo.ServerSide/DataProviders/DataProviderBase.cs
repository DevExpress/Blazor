using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemo.DataProviders {
    public abstract class DataProviderBase : IDataProvider {
        readonly SemaphoreSlim _lock = new SemaphoreSlim(1);
        Dictionary<string, object> dataWrappers = new Dictionary<string, object>();

        static readonly Task<IObservable<int>> CompletedLoadingState = Task.FromResult<IObservable<int>>(new DataProviderLoadingState());
        public virtual Task<IObservable<int>> GetLoadingStateAsync() => CompletedLoadingState;

        protected async Task<IEnumerable<TEntity>> LoadDataAsync<TEntity>(string dbSetKey, Func<DbSet<TEntity>> getData, Action<TEntity, string, object> updateFunc = null, CancellationToken ct = default) where TEntity : class, new() {
            await _lock.WaitAsync();
            if(!dataWrappers.ContainsKey(dbSetKey)) {
                var items = getData().AsNoTracking().ToList();
                var dataWrapper = new BlazorDemo.Data.DataWrapper<TEntity>(items, updateFunc);
                dataWrappers.Add(dbSetKey, dataWrapper);
            }
            _lock.Release();
            return GetDataWrapper<TEntity>(dbSetKey).Data;
        }
        protected async Task<IEnumerable<TEntity>> InsertAsync<TEntity>(string dbSetKey, IDictionary<string, object> newValues, CancellationToken ct = default) {
            var dataWrapper = GetDataWrapper<TEntity>(dbSetKey);
            await dataWrapper.Add(newValues);
            return dataWrapper.Data;
        }
        protected async Task<IEnumerable<TEntity>> RemoveAsync<TEntity>(string dbSetKey, TEntity dataItem, CancellationToken ct = default) {
            var dataWrapper = GetDataWrapper<TEntity>(dbSetKey);
            await dataWrapper.Remove(dataItem);
            return dataWrapper.Data;
        }
        protected async Task<IEnumerable<TEntity>> UpdateAsync<TEntity>(string dbSetKey, TEntity dataItem, IDictionary<string, object> newValues, CancellationToken ct = default) {
            var dataWrapper = GetDataWrapper<TEntity>(dbSetKey);
            await dataWrapper.Update(dataItem, newValues);
            return dataWrapper.Data;
        }

        protected BlazorDemo.Data.IDataWrapper<T> GetDataWrapper<T>(string dbSetKey) {
            return (BlazorDemo.Data.IDataWrapper<T>)dataWrappers[dbSetKey];
        }
    }
}
