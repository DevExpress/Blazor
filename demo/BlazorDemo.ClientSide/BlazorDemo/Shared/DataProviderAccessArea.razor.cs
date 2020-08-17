using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemo.DataProviders;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Shared {
    public partial class DataProviderAccessArea<T> : IObserver<int>, IDisposable
        where T : IDataProvider {

        private IDisposable[] _subscriptions;
        private int _dataProvidersCount;
        private int _progress;
        private bool _ready;
        private bool _notSupported;
        private string _onlineDemoUrl;
        [Inject] T DataProvider { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync() {
            var loadingStates = await GetLoadingStates();
            _notSupported = loadingStates.Any(x => x == null);
            if(_notSupported)
                _onlineDemoUrl = $"https://demos.devexpress.com/blazor{NavigationManager.ToAbsoluteUri(NavigationManager.Uri).PathAndQuery}";
            else
                _subscriptions = loadingStates.Select(x => x.Subscribe(this)).ToArray();
        }

        async Task<IEnumerable<IObservable<int>>> GetLoadingStates() {
            var dataProviders = GetDataProviders();
            var states = new List<IObservable<int>>();
            foreach(var dataProvider in dataProviders) {
                _dataProvidersCount++;
                var loadingState = await dataProvider.GetLoadingStateAsync();
                states.Add(loadingState);
            }
            return states;
        }
        protected virtual IEnumerable<IDataProvider> GetDataProviders() {
            yield return DataProvider;
        }
        public void OnCompleted() {
            if(--_dataProvidersCount == 0) {
                if(!_ready) {
                    _ready = true;
                    Unsubscribe();
                    InvokeAsync(StateHasChanged);
                }
            }
        }
        public void OnError(Exception error) { }
        public void OnNext(int value) {
            if(_progress != value) {
                _progress = value;
                InvokeAsync(StateHasChanged);
            }
        }
        public void Dispose() {
            try { Unsubscribe(); } catch { }
        }
        private void Unsubscribe() {
            if(_subscriptions != null) {
                foreach(var subscription in _subscriptions)
                    subscription?.Dispose();

                _subscriptions = null;
            }
        }
    }

    public class DataProviderAccessArea<T1, T2> : DataProviderAccessArea<T1>
        where T1 : IDataProvider
        where T2 : IDataProvider {

        [Inject] T2 DataProvider { get; set; }
        protected override IEnumerable<IDataProvider> GetDataProviders() {
            return base.GetDataProviders().Append(DataProvider);
        }
    }


    public class DataProviderAccessArea<T1, T2, T3> : DataProviderAccessArea<T1, T2>
        where T1 : IDataProvider
        where T2 : IDataProvider
        where T3 : IDataProvider {

        [Inject] T3 DataProvider { get; set; }
        protected override IEnumerable<IDataProvider> GetDataProviders() {
            return base.GetDataProviders().Append(DataProvider);
        }
    }
}
