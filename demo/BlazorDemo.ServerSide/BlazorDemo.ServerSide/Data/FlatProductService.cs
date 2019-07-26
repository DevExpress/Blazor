using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Blazor.Model;

namespace Demo.Blazor.Services
{
    public class FlatProductService
    {
        IList<ProductFlat> dataSource;
        public FlatProductService()
        {
            dataSource = FlatProducts.Load();
        }
        public Task<IQueryable<ProductFlat>> Load()
        {
            return Task.FromResult(dataSource.AsQueryable());
        }
    }
}
