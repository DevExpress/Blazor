using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Issues;
using BlazorDemo.DataProviders;
using BlazorDemo.Wasm.DataProviders.TransportInfrastructure;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    public class IssuesDataProvider : RemoteDataProviderBase, IIssuesDataProvider {
        public Task<IEnumerable<Issue>> GetIssuesAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetIssuesAsync);
        }
        public Task<IEnumerable<Project>> GetProjectsAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetProjectsAsync);
        }
        public Task<IEnumerable<User>> GetUsersAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetUsersAsync);
        }

        public IssuesDataProvider(RemoteDataProviderLoader loader) : base(loader) {
        }
    }
}

