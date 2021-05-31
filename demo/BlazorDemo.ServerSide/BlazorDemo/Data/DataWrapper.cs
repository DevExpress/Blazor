using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDemo.Data {
    public interface IDataWrapper<T> {
        IList<T> Data { get; }
        Task Update(T item, IDictionary<string, object> newValues);
        Task Add(IDictionary<string, object> newValues);
        Task Add(T item);
        Task Remove(T item);
    }

    public class DataWrapper<T>: IDataWrapper<T> where T : new() {
        readonly Action<T, string, object> updateFunc;

        public IList<T> Data { get; private set; }

        public DataWrapper(IList<T> data, Action<T, string, object> update) {
            Data = data;
            this.updateFunc = update;
        }

        public Task Update(T item, IDictionary<string, object> newValues) {
            return TaskFromResult(() => {
                foreach(var field in newValues.Keys)
                    updateFunc(item, field, newValues[field]);
            });
        }
        public Task Add(IDictionary<string, object> newValues) {
            return TaskFromResult(() => {
                T item = new T();
                Update(item, newValues);
                Data.Insert(0, item);
            });
        }
        public Task Add(T item) {
            return TaskFromResult(() => {
                Data.Insert(0, item);
            });
        }
        public Task Remove(T item) {
            return TaskFromResult(() => Data.Remove(item));
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
