using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Blazor.Model;

namespace Demo.Blazor.Services
{
    public class CountryNamesService
    {
        public Task<IQueryable<string>> Load()
        {
            return Task.FromResult(Countries.Names.AsQueryable());
        }
    }
}
