using System;

namespace BlazorDemo.Wasm.DataProviders.TransportInfrastructure {
    readonly struct DataProviderProgression {
        DataProviderProgression(IProgress<int> reporter, int loaded, int total,
            in ReadOnlyMemory<EntityLoadingState> remainingEntities) {
            Reporter = reporter;
            Loaded = loaded;
            Total = total;
            RemainingEntities = remainingEntities;
        }

        public IProgress<int> Reporter { get; }
        public readonly ReadOnlyMemory<EntityLoadingState> RemainingEntities;
        public int Loaded { get; }
        public int Total { get; }

        public bool HasMissingData() {
            return !RemainingEntities.IsEmpty && Loaded < Total;
        }

        public DataProviderProgression Update(int take) {
            return CreateCore(Reporter, Loaded + take, Total, RemainingEntities);
        }

        public static DataProviderProgression Create(IProgress<int> progress,
            in ReadOnlyMemory<EntityLoadingState> providerEntities) {
            int loaded = 0, total = 0;
            ReadOnlySpan<EntityLoadingState> span = providerEntities.Span;
            for (var i = 0; i < providerEntities.Length; i++) {
                ref readonly EntityLoadingState entity = ref span[i];
                ref readonly EntitySetMetadata meta = ref entity.Entity;
                loaded += entity.Loaded;
                total += meta.Total;
            }

            return CreateCore(progress, loaded, total, providerEntities);
        }

        public DataProviderProgression StartNextEntity() {
            return new DataProviderProgression(Reporter, Loaded, Total, RemainingEntities.Slice(1));
        }

        private static DataProviderProgression CreateCore(
            IProgress<int> progress,
            decimal loaded,
            decimal total,
            in ReadOnlyMemory<EntityLoadingState> remainingEntities) {
            var completed = (loaded / total) * 100;
            progress.Report((int)completed);
            return new DataProviderProgression(progress, (int)loaded, (int)total, remainingEntities);
        }
    }
}