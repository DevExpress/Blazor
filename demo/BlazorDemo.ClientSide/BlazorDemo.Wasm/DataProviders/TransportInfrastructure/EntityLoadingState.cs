using System;
using System.Runtime.Serialization;
using System.Text.Json;

namespace BlazorDemo.Wasm.DataProviders.TransportInfrastructure {
    readonly struct EntityLoadingState : IEquatable<EntityLoadingState> {
        EntityLoadingState(in EntitySetMetadata entity, int loaded) {
            Entity = entity;
            Loaded = loaded;
        }

        public readonly EntitySetMetadata Entity;
        public readonly int Loaded;

        public EntityLoadingState AddLoaded(int count) {
            return new EntityLoadingState(Entity, Loaded + count);
        }

        public static EntityLoadingState FromMetadata(in EntitySetMetadata entity) {
            return new EntityLoadingState(in entity, 0);
        }

        public bool Equals(EntityLoadingState other) {
            return Equals(Entity, other.Entity) && Loaded == other.Loaded;
        }

        public override bool Equals(object obj) {
            return obj is EntityLoadingState other && Equals(other);
        }

        public override int GetHashCode() {
            return HashCode.Combine(Entity, Loaded);
        }

        public override string ToString() {
            return $"{Entity} {Loaded}";
        }
    }
}