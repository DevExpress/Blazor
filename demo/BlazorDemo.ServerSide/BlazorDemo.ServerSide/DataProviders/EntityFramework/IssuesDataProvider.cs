using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Issues;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemo.DataProviders {
    class IssuesDataProvider : DataProviderBase, IIssuesDataProvider {
        private readonly IssuesContext _context;

        public IssuesDataProvider(IssuesContext context) {
            _context = context;
        }

        public async Task<IEnumerable<Issue>> GetItemsAsync(CancellationToken ct = default) {
            return await LoadDataAsync("Issues", () => _context.Items, null, ct);
        }
        public async Task<IEnumerable<Project>> GetProjectsAsync(CancellationToken ct = default) {
            return await LoadDataAsync("Projects", () => _context.Projects, null, ct);
        }
        public async Task<IEnumerable<User>> GetUsersAsync(CancellationToken ct = default) {
            return await LoadDataAsync("Users", () => _context.Users, null, ct);
        }
    }
}

