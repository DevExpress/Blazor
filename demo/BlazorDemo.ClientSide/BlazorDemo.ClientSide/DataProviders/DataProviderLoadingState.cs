using System;

namespace BlazorDemo.DataProviders {
    sealed class DataProviderLoadingState : IObservable<int> {
        public IDisposable Subscribe(IObserver<int> observer) {
            observer.OnCompleted();
            return null;
        }
    }
}
