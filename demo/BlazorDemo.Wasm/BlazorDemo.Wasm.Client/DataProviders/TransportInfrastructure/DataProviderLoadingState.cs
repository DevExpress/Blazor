using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorDemo.Wasm.DataProviders.TransportInfrastructure {
    class DataProviderLoadingState : IObservable<int>, IProgress<int> {
        readonly ISet<IObserver<int>> _observers = new HashSet<IObserver<int>>();
        int _value;

        public void Report(int value) {
            if(_value != value) {
                _value = value;
                var observers = _observers.ToArray();
                if(_value == 100) {
                    _observers.Clear();
                    foreach(var observer in observers)
                        observer.OnCompleted();
                } else {
                    foreach(var observer in observers)
                        observer.OnNext(_value);
                }
            }
        }

        public IDisposable Subscribe(IObserver<int> observer) {
            if(_value == 100) {
                observer.OnCompleted();
                return null;
            }

            observer.OnNext(_value);
            return UnsubscribeCallback<IObserver<int>>.Create(_observers, observer);
        }
    }
}
