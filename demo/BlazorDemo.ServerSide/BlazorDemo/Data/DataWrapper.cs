using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDemo.Data {
    public class DataWrapper<T> where T : new() {
        readonly Action<T, string, object> updateFunc;

        public IList<T> Data { get; private set; }

        public DataWrapper(IList<T> data, Action<T, string, object> update) {
            Data = data;
            this.updateFunc = update;
        }

        public Task Update(T item, IDictionary<string, object> newValue) {
            return TaskFromResult(() => {
                foreach (var field in newValue.Keys)
                    updateFunc(item, field, newValue[field]);
            });
        }
        public Task Add(IDictionary<string, object> newValue) {
            return TaskFromResult(() => {
                T item = new T();
                Update(item, newValue);
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