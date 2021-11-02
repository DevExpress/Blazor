using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Issues;

namespace BlazorDemo.DataProviders {
    [Guid("DD279962-7EC6-494E-8C8E-416C9065D64D")]
    public interface IIssuesDataProvider : IDataProvider {
        Task<IEnumerable<Issue>> GetIssuesAsync(CancellationToken ct = default);
        Task<IEnumerable<Project>> GetProjectsAsync(CancellationToken ct = default);
        Task<IEnumerable<User>> GetUsersAsync(CancellationToken ct = default);
    }
}
