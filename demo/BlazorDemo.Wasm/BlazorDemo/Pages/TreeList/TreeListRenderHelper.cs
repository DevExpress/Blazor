using System;
using BlazorDemo.Data;
namespace BlazorDemo.Pages.TreeList {
    public static class TreeListRenderHelper {
        public static string EmployeeTaskPriorityToString(EmployeeTask employeeTask) {
            return employeeTask.Priority switch {
                -1 => "Low",
                0 => "Medium",
                1 => "High",
                _ => throw new ArgumentException()
            };
        }

        public static string EmployeeTaskStatusToString(EmployeeTask employeeTask) {
            return employeeTask.Status < 100 ? "In progress" : "Completed";
        }
    }
}
