using System.Collections.Generic;
using System.Linq;

namespace BlazorDemo.Data.Employees;

public static class Employees {
    public static List<Employee> EmployeesList = new List<Employee>() {
        new Employee("Bruce", "Cambell", "Administration"),
        new Employee("Cindy", "Haneline", "Administration"),
        new Employee("Andrea", "Deville", "Administration"),
        new Employee("Carolin", "Baker", "Sales and Marketing"),
        new Employee("Anthony", "Rounds", "Sales and Marketing"),
        new Employee("Aaron", "Borrmann", "Sales and Marketing"),
        new Employee("Anita", "Benson", "Inventory Management"),
        new Employee("Barbara", "Chapman", "Inventory Management"),
        new Employee("Angela", "Mccallum", "Inventory Management"),
        new Employee("Alphonso", "Johnson", "Sales and Marketing"),
        new Employee("Essie", "Teter", "Manufacturing"),
        new Employee("Angelia", "Hanna", "Manufacturing"),
        new Employee("Barbara", "Faircloth", "Manufacturing")
    };

    public static List<EmployeeDepartment> Departments => EmployeesList.GroupBy(x => x.GroupName).Select(x => new EmployeeDepartment(x.Key, x.ToList())).ToList();
}
