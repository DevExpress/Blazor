using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.DataProviders {
    public interface IDataWrapper<T> {
        Task<List<T>> GetDataAsync();

        Task Add(IDictionary<string, object> newValues, Action<T, IDictionary<string, object>> updateFunc, Action<IQueryable<T>, T> updateKeyFunc);
        Task Add(T item, Action<IQueryable<T>, T> updateKeyFunc);
        Task UpdateByValues(T item, IDictionary<string, object> newValues, Action<T, IDictionary<string, object>> updateFunc);
        Task UpdateByItem(T item, T newItem, Action<T, T> updateFunc);
        Task Remove(T item);
    }

    public class DataWrapper<T>: IDataWrapper<T> where T : class, new() {
        protected List<T> Data { get; set; }

        public DataWrapper(List<T> data) {
            Data = data;
        }

        public Task<List<T>> GetDataAsync() {
            return Task.FromResult(Data);
        }
        public Task UpdateByValues(T item, IDictionary<string, object> newValues, Action<T, IDictionary<string, object>> updateFunc) {
            return TaskFromResult(() => {
                 updateFunc(item, newValues);
            });
        }
        public Task UpdateByItem(T item, T newItem, Action<T, T> updateFunc) {
            return TaskFromResult(() => {
                updateFunc(item, newItem);
            });
        }
        public Task Add(IDictionary<string, object> newValues, Action<T, IDictionary<string, object>> updateFunc, Action<IQueryable<T>, T> updateKeyFunc) {
            return TaskFromResult(() => {
                T item = new T();
                UpdateByValues(item, newValues, updateFunc);
                if(updateKeyFunc != null)
                    updateKeyFunc(Data.AsQueryable<T>(), item);
                Data.Insert(0, item);
            });
        }
        public Task Add(T item, Action<IQueryable<T>, T> updateKeyFunc) {
            return TaskFromResult(() => {
                if(updateKeyFunc != null)
                    updateKeyFunc(Data.AsQueryable<T>(), item);
                Data.Insert(0, item);
            });
        }
        public Task Remove(T item) {
            return TaskFromResult(() => {
                Data.Remove(item);
            });
        }

        Task TaskFromResult(Action action) {
            Func<bool> func = () => {
                action();
                return true;
            };
            return Task.FromResult(func());
        }
    }
}
