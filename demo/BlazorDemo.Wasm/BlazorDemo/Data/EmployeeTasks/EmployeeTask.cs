using System;

namespace BlazorDemo.Data.EmployeeTasks {
    public class EmployeeTask {
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Employee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public int Priority { get; set; }
        public int Status { get; set; }

        public bool HasDescription => !string.IsNullOrEmpty(Description);
        public bool IsCompleted => Status == 100;
    }
}
