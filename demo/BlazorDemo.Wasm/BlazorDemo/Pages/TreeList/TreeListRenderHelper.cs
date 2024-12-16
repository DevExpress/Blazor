using System;
using System.Collections.Generic;
using BlazorDemo.Data;
namespace BlazorDemo.Pages.TreeList {
    public static class TreeListRenderHelper {
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

        public static IEnumerable<string> SpaceObjectTypes { get; } = new[] {
            "Star",
            "Planet",
            "Dwarf planet",
            "Satellite",
            "Asteroid"
        };
    }
}
