using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Wasm.DataProviders.TransportInfrastructure {
    public readonly struct EntityId : IEquatable<EntityId> {
        public Guid Provider { get; }

        public Guid Entity { get; }

        public EntityId(Guid provider, Guid entity) {
            Provider = provider;
            Entity = entity;
        }

        public bool Equals(EntityId other) {
            return Provider.Equals(other.Provider) && Entity.Equals(other.Entity);
        }

        public override bool Equals(object obj) {
            return obj is EntityId other && Equals(other);
        }

        public override int GetHashCode() {
            return (Provider, Entity).GetHashCode();
        }

        public override string ToString() {
            return JsonSerializer.Serialize(this);
        }

        public static EntityId FromTypes<TService, TEntity>() where TService : IDataProvider {
            return new EntityId(GetServiceId(typeof(TService)), typeof(TEntity).GUID);
        }

        public static Guid GetServiceId(Type type) {
            var providerContractType = GetProviderContractType(type);
            if (providerContractType == null)
                throw new InvalidOperationException();
            return providerContractType.GUID;
        }

        public static string GetDataProviderContractTypeName(Type type) {
            var providerContractType = GetProviderContractType(type);
            if (providerContractType == null)
                throw new InvalidOperationException();
            return providerContractType.Name;
        }

        static Type GetProviderContractType(Type type) {
            if (IsDataProviderContract(type))
                return type;
            return type.GetInterfaces().FirstOrDefault(IsDataProviderContract);
        }

        static bool IsDataProviderContract(Type x) {
            var baseInterface = typeof(IDataProvider);
            return baseInterface.IsAssignableFrom(x) && x.IsInterface && x != baseInterface;
        }
    }
}