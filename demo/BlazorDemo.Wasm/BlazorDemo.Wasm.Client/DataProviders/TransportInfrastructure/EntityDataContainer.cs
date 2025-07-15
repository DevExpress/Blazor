using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;

namespace BlazorDemo.Wasm.DataProviders.TransportInfrastructure {
    public sealed class EntityDataContainer {

        sealed class EntityWrapper<T> {
            public T DataObject { get; }
            public bool IsDeleted { get; set; }

            public EntityWrapper(T dataObject) {
                DataObject = dataObject;
            }
        }
#if MAUI
        public
#else
        readonly
#endif
        NavigationManager _navigationManager;
        readonly ReadOnlyCollectionBuilder<EntityWrapper<object>> _bufferBuilder;
        readonly TaskCompletionSource<ReadOnlyCollection<EntityWrapper<object>>> _tcs = new();
        readonly IList<EntityWrapper<object>> _offlineData = new List<EntityWrapper<object>>();
        string _prevUri;
        public EntityDataContainer(NavigationManager navigationManager) {
            _navigationManager = navigationManager;
            _bufferBuilder = new ReadOnlyCollectionBuilder<EntityWrapper<object>>();
        }
        public void Append(object[] items) {
            for(int i = 0; i < items.Length; i++)
                _bufferBuilder.Add(new EntityWrapper<object>(items[i]));
        }


        public async Task<IEnumerable<TEntity>> GetData<TEntity>() {
            var data = await GetData();
            var offlineData = await GetOfflineData();
            return offlineData.Concat(data).Where(x => !x.IsDeleted).Select(x => x.DataObject).Cast<TEntity>();
        }

        public async Task Delete<TEntity>(TEntity item) {
            var data = await GetData();
            var offlineData = await GetOfflineData();

            var wrapper = offlineData.Concat(data).FirstOrDefault(x => EqualityComparer<TEntity>.Default.Equals((TEntity)x.DataObject, item));
            if(wrapper != null)
                wrapper.IsDeleted = true;
        }

        public async Task Add<TEntity>(TEntity entity) {
            var offlineData = await GetOfflineData();
            offlineData.Add(new EntityWrapper<object>(entity));
        }

        public void CompleteLoading() {
            _tcs.TrySetResult(_bufferBuilder.ToReadOnlyCollection());
        }

        async Task<IEnumerable<EntityWrapper<object>>> GetData() {
            await ResetDataIfNavigationChanged();
            return await _tcs.Task;
        }

        async Task<IList<EntityWrapper<object>>> GetOfflineData() {
            await ResetDataIfNavigationChanged();
            return _offlineData;
        }

        async Task ResetDataIfNavigationChanged() {
            if(_prevUri == _navigationManager.Uri)
                return;

            var data = await _tcs.Task;
            for(int i = 0; i < data.Count; i++)
                data[i].IsDeleted = false;
            _offlineData.Clear();

            _prevUri = _navigationManager.Uri;
        }
    }
}
