using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    [Guid("21476BD9-7B6C-4E0E-961D-56E80C3EFAF7")]
    public interface IContosoRetailDataProvider : IDataProvider {
        IQueryable<Sale> GetSales();
    }
}
