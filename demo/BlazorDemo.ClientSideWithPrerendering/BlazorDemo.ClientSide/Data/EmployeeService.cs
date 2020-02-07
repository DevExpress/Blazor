using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Blazor.Model;

namespace Demo.Blazor.Services {
    public class EmployeeService {
        IList<Employee> dataSource;

        public EmployeeService() {
            dataSource = Employees.Load();
        }
        public void Remove(Employee dataItem) {
            ((IList<Employee>)dataSource).Remove(dataItem);
        }
        public void Update(Employee product, Dictionary<string, object> newValue) {
            foreach (var field in newValue.Keys) {
                switch (field) {
                    case "BirthDate":
                        product.BirthDate = (DateTime)newValue[field];
                        break;
                    case "FirstName":
                        product.FirstName = (string)newValue[field];
                        break;
                    case "LastName":
                        product.LastName = (string)newValue[field];
                        break;
                    case "Position":
                        product.Position = (string)newValue[field];
                        break;
                    case "Title":
                        product.Title = (string)newValue[field];
                        break;
                    case "Notes":
                        product.Notes = (string)newValue[field];
                        break;
                    case "HireDate":
                        product.HireDate = (DateTime)newValue[field];
                        break;
                    case "FileName":
                        product.FileName = (string)newValue[field];
                        break;
                }
            }
        }
        public Task<IQueryable<Employee>> Load() {
            return Task.FromResult(dataSource.AsQueryable());
        }

        public void Insert(Dictionary<string, object> newValue)
        {
            if(!newValue.ContainsKey(nameof(Employee.LastName)))
                newValue.Add(nameof(Employee.LastName), Guid.NewGuid().ToString());

            var dataItem = new Employee();
            dataItem.FileName = "Unavailable";
            Update(dataItem, newValue);
            ((IList<Employee>)dataSource).Add(dataItem);
        }
    }
}