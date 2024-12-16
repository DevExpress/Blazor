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
    }
}

