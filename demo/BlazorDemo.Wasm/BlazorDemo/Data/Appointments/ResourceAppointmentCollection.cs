using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorDemo.Data {

    public static partial class ResourceAppointmentCollection {
        public static List<ResourceAppointment> GetAppointments() {
            DateTime date = DateTime.Now.Date;
            var dataSource = new List<ResourceAppointment>() {
                new ResourceAppointment {
                    Caption = "Install New Router in Dev Room",
                    StartDate = date + (new TimeSpan(0, 10, 0, 0)),
                    EndDate = date + (new TimeSpan(0, 12, 0, 0)),
                    Status = 1,
                    ResourceId = 0
                },
                new ResourceAppointment {
                    Caption = "Upgrade Personal Computers",
                    StartDate = date + (new TimeSpan(0,  13, 0, 0)),
                    EndDate = date + (new TimeSpan(0, 14, 30, 0)),
                    Status = 1,
                    ResourceId = 0
                },
                new ResourceAppointment {
                    Caption = "Website Re-Design Plan",
                    StartDate = date + (new TimeSpan(1, 9, 30, 0)),
                    EndDate = date + (new TimeSpan(1, 11, 30, 0)),
                    Status = 1,
                    ResourceId = 0
                },
                new ResourceAppointment {
                    Caption = "New Brochures",
                    StartDate = date + (new TimeSpan(1, 13, 30, 0)),
                    EndDate = date + (new TimeSpan(1, 15, 15, 0)),
                    Status = 1,
                    ResourceId = 0
                },
                new ResourceAppointment {
                    Caption = "Book Flights to San Fran for Sales Trip",
                    StartDate = date + (new TimeSpan(1, 12, 0, 0)),
                    EndDate = date + (new TimeSpan(1, 13, 0, 0)),
                    AllDay = true,
                    Status = 1,
                    ResourceId = 0
                },
                new ResourceAppointment {
                    Caption = "Approve Personal Computer Upgrade Plan",
                    StartDate = date + (new TimeSpan(0, 10, 0, 0)),
                    EndDate = date + (new TimeSpan(0, 12, 0, 0)),
                    Status = 1
                },
                new ResourceAppointment {
                    Caption = "Final Budget Review",
                    StartDate = date + (new TimeSpan(0, 13, 0, 0)),
                    EndDate = date + (new TimeSpan(0, 15, 0, 0)),
                    Status = 1,
                    ResourceId = 1
                },
                new ResourceAppointment {
                    Caption = "Install New Database",
                    StartDate = date + (new TimeSpan(0, 9, 45, 0)),
                    EndDate = date + (new TimeSpan(1, 11, 15, 0)),
                    Status = 1,
                    ResourceId = 1
                },
                new ResourceAppointment {
                    Caption = "Approve New Online Marketing Strategy",
                    StartDate = date + (new TimeSpan(1,  12, 0, 0)),
                    EndDate = date + (new TimeSpan(1, 14, 0, 0)),
                    Status = 1,
                    ResourceId = 1
                },
                new ResourceAppointment {
                    Caption = "Customer Workshop",
                    StartDate = date + (new TimeSpan(0,  11, 0, 0)),
                    EndDate = date + (new TimeSpan(0, 12, 0, 0)),
                    AllDay = true,
                    Status = 1,
                    ResourceId = 2
                },
                new ResourceAppointment {
                    Caption = "Prepare 2021 Marketing Plan",
                    StartDate = date + (new TimeSpan(0,  11, 0, 0)),
                    EndDate = date + (new TimeSpan(0, 13, 30, 0)),
                    Status = 1,
                    ResourceId = 2
                },
                new ResourceAppointment {
                    Caption = "Brochure Design Review",
                    StartDate = date + (new TimeSpan(0, 14, 0, 0)),
                    EndDate = date + (new TimeSpan(0, 15, 30, 0)),
                    Status = 1,
                    ResourceId = 2
                },
                new ResourceAppointment {
                    Caption = "Create Icons for Website",
                    StartDate = date + (new TimeSpan(1, 10, 0, 0)),
                    EndDate = date + (new TimeSpan(1, 11, 30, 0)),
                    Status = 1,
                    ResourceId = 1
                },
                new ResourceAppointment {
                    Caption = "Launch New Website",
                    StartDate = date + (new TimeSpan(1, 12, 20, 0)),
                    EndDate = date + (new TimeSpan(1, 14, 0, 0)),
                    Status = 1,
                    ResourceId = 2
                },
                new ResourceAppointment {
                    Caption = "Upgrade Server Hardware",
                    StartDate = date + (new TimeSpan(1, 9, 0, 0)),
                    EndDate = date + (new TimeSpan(1, 12, 0, 0)),
                    Status = 1,
                    ResourceId = 2
                },
                new ResourceAppointment {
                    Caption = "Book Flights to San Fran for Sales Trip",
                    StartDate = date + (new TimeSpan(0, 14, 0, 0)),
                    EndDate = date + (new TimeSpan(0, 17, 0, 0)),
                    Status = 1,
                    ResourceId = 3
                },
                new ResourceAppointment {
                    Caption = "Approve New Online Marketing Strategy",
                    StartDate = date + (new TimeSpan(0,  12, 0, 0)),
                    EndDate = date + (new TimeSpan(0, 15, 0, 0)),
                    Status = 1,
                    ResourceId = 4
                }
            };
            return dataSource;
        }

        public static List<Resource> GetResourcesForGrouping() {
            return GetResources().Take(3).ToList();
        }

        public static List<Resource> GetResources() {
            return new List<Resource>() {
                new Resource() { Id=0 , Name="John Heart", GroupId=100, BackgroundCss="dx-green-color", TextCss="text-white" },
                new Resource() { Id=1 , Name="Samantha Bright", GroupId=101, BackgroundCss="dx-orange-color", TextCss="text-white" },
                new Resource() { Id=2 , Name="Arthur Miller", GroupId=100, BackgroundCss="dx-purple-color", TextCss="text-white" },
                new Resource() { Id=3 , Name="Robert Reagan", GroupId=101, BackgroundCss="dx-indigo-color", TextCss="text-white" },
                new Resource() { Id=4 , Name="Greta Sims", GroupId=100, BackgroundCss="dx-red-color", TextCss="text-white" }
            };
        }

        public static List<Resource> GetResourceGroups() {
            return new List<Resource>() {
                new Resource() { Id=100, Name="Sales and Marketing", IsGroup=true },
                new Resource() { Id=101, Name="Engineering", IsGroup=true }
            };
        }
    }
}
