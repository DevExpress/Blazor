using System.Collections.Generic;

namespace BlazorDemo.Data.Employees;

public class EmployeeDepartment {
    public string Name { get; }
    public List<Employee> Employees { get; }
    public bool AllowCheck => false;

    public EmployeeDepartment(string name, IList<Employee> employees) {
        Name = name;
        Employees = new List<Employee>(employees);
    }
}
