using System;
using System.Collections.Generic;

namespace BlazorDemo.Wasm.DataProviders.TransportInfrastructure {
    readonly struct UnsubscribeCallback<T> : IDisposable {
        readonly MulticastDelegate _delegate;
        readonly T _target;

        private UnsubscribeCallback(MulticastDelegate @delegate, T target) {
            _delegate = @delegate;
            _target = target;
        }

        public static UnsubscribeCallback<T> Create(in ISet<T> container, in T target) {
            if (!container.Contains(target))
                container.Add(target);
            return new UnsubscribeCallback<T>((Func<T, bool>)container.Remove, target);
        }

        public void Dispose() {
            try {
                switch (_delegate) {
                    case Func<T, bool> disposeFunc:
                        disposeFunc(_target);
                        break;
                    case Action<T> disposeAction:
                        disposeAction(_target);
                        break;
                }
            } catch { }
        }
    }
}