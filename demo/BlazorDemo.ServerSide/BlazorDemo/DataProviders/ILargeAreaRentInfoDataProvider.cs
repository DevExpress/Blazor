using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders;

public interface ILargeAreaRentInfoDataProvider : IDataProvider {
    IQueryable<LargeAreaRentInfo> GetLargeAreaRentInfo();
}
