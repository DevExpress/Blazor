using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Issues;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BlazorDemo.DataProviders {
    class IssuesDataProvider : EntityDataProvider<IssuesContext>, IIssuesDataProvider {
        public IssuesDataProvider(IDbContextFactory<IssuesContext> contextFactory, IConfiguration configuration) : base(contextFactory, configuration) { }

        public async Task<IEnumerable<Issue>> GetItemsAsync(CancellationToken ct = default) {
            return await LoadDataAsync<Issue>("Issues", ct);
        }
        public async Task<IEnumerable<Project>> GetProjectsAsync(CancellationToken ct = default) {
            return await LoadDataAsync<Project>("Projects", ct);
        }
        public async Task<IEnumerable<User>> GetUsersAsync(CancellationToken ct = default) {
            return await LoadDataAsync<User>("Users", ct);
        }
    }
}

