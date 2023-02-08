using System.Collections.Generic;

namespace BlazorDemo.Data.Northwind {
    public class EmployeeDepartment {
        public string Name { get; }
        public List<Employee> Employees { get; }
        public bool AllowSelection => false;

        public EmployeeDepartment(string name, IList<Employee> employees) {
            this.Name = name;
            this.Employees = new List<Employee>(employees);
        }
    }
}
