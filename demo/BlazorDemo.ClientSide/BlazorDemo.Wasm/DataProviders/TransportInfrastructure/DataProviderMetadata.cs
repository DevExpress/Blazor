using System;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace BlazorDemo.Wasm.DataProviders.TransportInfrastructure {

    public readonly struct EntitySetMetadata : IEquatable<EntitySetMetadata> {
        public int Total { get; }
        public EntityId Id { get; }

        public EntitySetMetadata(Guid provider, Guid entity, int total) : this(new EntityId(provider, entity), total) {
        }

        [JsonConstructor]
        public EntitySetMetadata(EntityId id, int total) {
            Id = id;
            Total = total;
        }

        public bool Equals(EntitySetMetadata other) {
            return Total == other.Total && Id.Equals(other.Id);
        }

        public override bool Equals(object obj) {
            return obj is EntitySetMetadata other && Equals(other);
        }

        public override int GetHashCode() {
            return (Total, Id).GetHashCode();
        }
        public override string ToString() {
            return JsonSerializer.Serialize(this);
        }
    }
}