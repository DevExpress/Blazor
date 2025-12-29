using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DevExpress.Data.Utils.Security;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorDemo.Services {
    public interface ICspNonceService {
        string Nonce { get; }
    }
    public interface ICspNonceWriter {
        void SetNonce(string nonce);
    }

    public class CspNonceService : ICspNonceService, ICspNonceWriter, IDisposable {
        const string NonceKey = "csp-style-nonce-key";
        string _nonce;

        public CspNonceService(IServiceProvider serviceProvider) {
            ServiceProvider = serviceProvider;
            ApplicationState = ServiceProvider.GetService<PersistentComponentState>();
            Subscription = ApplicationState.RegisterOnPersisting(PersistNonce);

            TryLoadNonce(); // wasm routing specific
        }

        IServiceProvider ServiceProvider { get; }
        PersistentComponentState ApplicationState { get; }
        PersistingComponentStateSubscription Subscription { get; set; }

        public string Nonce {
            get {
                if(string.IsNullOrEmpty(_nonce) && !TryLoadNonce())
                    _nonce = Convert.ToBase64String(StrongRandom.GetBytes(16));
                return _nonce;
            }
        }

        bool TryLoadNonce() {
            return ApplicationState.TryTakeFromJson(NonceKey, out _nonce);
        }

        async Task PersistNonce() {
            ApplicationState.PersistAsJson(NonceKey, _nonce);
            await Task.CompletedTask;
        }

        public void SetNonce(string nonce) {
            _nonce = nonce;
        }

        void IDisposable.Dispose() {
            Subscription.Dispose();
        }
    }
}
