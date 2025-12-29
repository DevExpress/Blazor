using System;
using System.ComponentModel.DataAnnotations;
using BlazorDemo.Data.Annotations;

namespace BlazorDemo.Data {
    public class EmployeeTask {
        public int Id { get; set; }
        public int ParentId { get; set; }

        [Required(ErrorMessage = "The Task field is required")]
        public string Name { get; set; }
        public string EmployeeName { get; set; }

        [DateIsEarlierThan("DueDate")]
        [Range(typeof(DateTime), "01/01/2017", "01/01/2027", ErrorMessage = "{0} must be between {1:d} and {2:d}")]
        public DateTime StartDate { get; set; }

        [Range(typeof(DateTime), "01/01/2017", "01/01/2027", ErrorMessage = "{0} must be between {1:d} and {2:d}")]
        public DateTime DueDate { get; set; }

        public int Priority { get; set; }

        public int Status { get; set; }
        public string Description { get; set; }
        public bool HasChildren { get; set; }

        public bool HasDescription => !string.IsNullOrEmpty(Description);
        public bool IsCompleted => Status == 100;

        // Extended Properties
        public string PriorityLabel { get; set; }
        public int EstimatedHours { get; set; }
        public int ActualHours { get; set; }
        public double Progress { get; set; }
        public decimal Budget { get; set; }
        public decimal Cost { get; set; }
        public string RiskLevel { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string Owner { get; set; }
        public string Reviewer { get; set; }
        public string Approver { get; set; }
        public string Department { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsBlocked { get; set; }
        public string ExternalId { get; set; }
        public string Epic { get; set; }
        public string Environment { get; set; }

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
        public EmployeeTask Clone() {
            return (EmployeeTask)MemberwiseClone();
        }

        public static string EmployeeTaskPriorityToString(EmployeeTask employeeTask) {
            return TaskPriorityToString(employeeTask.Priority);
        }
        public static string TaskPriorityToString(int taskPriority) {
            if(taskPriority == 0)
                return "Medium";
            if(taskPriority > 0)
                return "High";
            return "Low";
        }
        public static string EmployeeTaskStatusToString(EmployeeTask employeeTask) {
            return employeeTask.Status < 100 ? "In progress" : "Completed";
        }
    }
}

