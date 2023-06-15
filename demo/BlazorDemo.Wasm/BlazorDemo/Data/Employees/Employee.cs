namespace BlazorDemo.Data.Employees;

public class Employee {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => FirstName + " " + LastName;
    public string GroupName { get; set; }

    public Employee(string firstName, string lastName, string groupName) {
        FirstName = firstName;
        LastName = lastName;
        GroupName = groupName;
    }
}
