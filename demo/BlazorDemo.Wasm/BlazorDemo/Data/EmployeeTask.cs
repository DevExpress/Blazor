using System;

namespace BlazorDemo.Data {
    public class EmployeeTask {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string EmployeeName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public int Priority { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public bool HasChildren { get; set; }

        public EmployeeTask(
            int id,
            int parentId,
            string name,
            string employeeName,
            string startDate,
            string dueDate,
            int priority,
            int status,
            string description,
            bool hasChildren = false
            ) : this() {
            Id = id;
            ParentId = parentId;
            Name = name;
            EmployeeName = employeeName;
            StartDate = DateTime.Parse(startDate);
            DueDate = DateTime.Parse(dueDate);
            Status = status;
            Priority = priority;
            Description = description;
            HasChildren = hasChildren;
        }

        public EmployeeTask() { }
    }
}

