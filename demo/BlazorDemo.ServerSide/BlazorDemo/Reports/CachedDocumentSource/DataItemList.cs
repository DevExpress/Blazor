using System;
using System.Collections;
using System.Collections.Generic;

namespace BlazorDemo.Reports.CachedDocumentSourceReport {
    public class DataItemList : IList<DataItem>, IList {
        readonly int rowCount;

        public DataItem this[int index] { get { return new DataItem(index); } set { } }
        public int Count { get { return rowCount; } }
        public bool IsReadOnly { get { return false; } }
        public bool IsFixedSize { get { return false; } }
        public object SyncRoot { get { return true; } }
        public bool IsSynchronized { get { return true; } }
        object IList.this[int index] { get { return new DataItem(index); } set { } }

        public DataItemList(int rowCount) {
            this.rowCount = rowCount;
        }
        public IEnumerator<DataItem> GetEnumerator() {
            throw new NotImplementedException();
        }
        public int Add(object value) {
            throw new NotImplementedException();
        }
        public bool Contains(object value) {
            throw new NotImplementedException();
        }
        public void Clear() {
            throw new NotImplementedException();
        }
        public int IndexOf(object value) {
            throw new NotImplementedException();
        }
        public void Insert(int index, object value) {
            throw new NotImplementedException();
        }
        public void Remove(object value) {
            throw new NotImplementedException();
        }
        public void RemoveAt(int index) {
            throw new NotImplementedException();
        }
        public void CopyTo(Array array, int index) {
            throw new NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator() {
            throw new NotImplementedException();
        }
        public int IndexOf(DataItem item) {
            throw new NotImplementedException();
        }
        public void Insert(int index, DataItem item) {
            throw new NotImplementedException();
        }
        public void Add(DataItem item) {
            throw new NotImplementedException();
        }
        public bool Contains(DataItem item) {
            throw new NotImplementedException();
        }
        public void CopyTo(DataItem[] array, int arrayIndex) {
            throw new NotImplementedException();
        }
        public bool Remove(DataItem item) {
            throw new NotImplementedException();
        }
        void ICollection<DataItem>.CopyTo(DataItem[] array, int arrayIndex) {
            CopyTo(array, arrayIndex);
        }
    }
}
