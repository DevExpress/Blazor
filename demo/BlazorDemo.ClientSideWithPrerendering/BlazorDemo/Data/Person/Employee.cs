using System;

namespace BlazorDemo.Data {
    public class Employee {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Notes { get; set; }
        public string FileName { get; set; }
    }
}