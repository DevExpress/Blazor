using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.Wasm.Server.DataProviders;

namespace BlazorDemo.DataProviders.Implementation {
    public class ExperimentResultDataProvider : DataProviderBase, IExperimentResultDataProvider {
        public Task<IEnumerable<DataPoint>> GetResultAsync(CancellationToken ct = default) {
            return Task.FromResult(_dataSource.Value);
        }
        static readonly Lazy<IEnumerable<DataPoint>> _dataSource = new Lazy<IEnumerable<DataPoint>>(GenerateDataSource);

        static IEnumerable<DataPoint> GenerateDataSource() {
            var rng = RandomWrapperFactory.Create();
            double x, y;
            for(int i = 0; i < 20; i++) {
                x = Random(5, 15);
                y = Random(5, 15);

                yield return new(x, y);

                x = Random(5, 15);
                y = Random(-15, -5);

                yield return new(x, y);

                x = Random(-15, -5);
                y = Random(5, 15);

                yield return new(x, y);

                x = Random(-15, -5);
                y = Random(-15, -5);

                yield return new(x, y);
            }
            double Random(double min, double max) => rng.NextDouble() * (max - min + 1) + min;
        }
    }
}
