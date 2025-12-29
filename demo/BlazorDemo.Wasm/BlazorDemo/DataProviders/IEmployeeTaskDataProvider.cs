using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IEmployeeTaskDataProvider {
        public List<EmployeeTask> GenerateData();

        public List<EmployeeTask> GenerateLargeData();
        public List<EmployeeTask> GenerateExtendedData();
    }
}
