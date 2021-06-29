using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.DataProviders {
    public interface IDataWrapper<T> {
        Task<List<T>> GetData();

        Task Add(IDictionary<string, object> newValues, Action<T, string, object> updateFunc, Action<IQueryable<T>, T> updateKeyFunc);
        Task Add(T item, Action<IQueryable<T>, T> updateKeyFunc);
        Task Update(T item, IDictionary<string, object> newValues, Action<T, string, object> updateFunc);
        Task Remove(T item);
    }

    public class DataWrapper<T>: IDataWrapper<T> where T : class, new() {
        protected List<T> Data { get; set; }

        public DataWrapper(List<T> data) {
            Data = data;
        }

        public Task<List<T>> GetData() {
            return Task.FromResult(Data);
        }
        public Task Update(T item, IDictionary<string, object> newValues, Action<T, string, object> updateFunc) {
            return TaskFromResult(() => {
                foreach(var field in newValues.Keys)
                    updateFunc(item, field, newValues[field]);
            });
        }
        public Task Add(IDictionary<string, object> newValues, Action<T, string, object> updateFunc, Action<IQueryable<T>, T> updateKeyFunc) {
            return TaskFromResult(() => {
                T item = new T();
                Update(item, newValues, updateFunc);
                updateKeyFunc(Data.AsQueryable<T>(), item);
                Data.Insert(0, item);
            });
        }
        public Task Add(T item, Action<IQueryable<T>, T> updateKeyFunc) {
            return TaskFromResult(() => {
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
