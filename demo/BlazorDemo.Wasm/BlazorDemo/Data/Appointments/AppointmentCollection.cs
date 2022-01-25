using System;
using System.Collections.Generic;

namespace BlazorDemo.Data {

    public static partial class AppointmentCollection {
        public static List<Appointment> GetAppointments() {
            DateTime date = DateTimeUtils.GetWeekStart(DateTime.Now);
            var dataSource = new List<Appointment>() {
                new Appointment {
                    Caption = "Install New Router in Dev Room",
                    StartDate = date + (new TimeSpan(0, 10, 0, 0)),
                    EndDate = date + (new TimeSpan(0, 12, 30, 0)),
                    Label = 6,
                    Status = 4
                },
                new Appointment {
                    Caption = "Upgrade Personal Computers",
                    StartDate = date + (new TimeSpan(0,  13, 0, 0)),
                    EndDate = date + (new TimeSpan(0, 15, 30, 0)),
                    Label = 1,
                    Status = 4
                },
                new Appointment {
                    Caption = "Website Redesign Plan",
                    StartDate = date + (new TimeSpan(1, 9, 30, 0)),
                    EndDate = date + (new TimeSpan(1, 12, 0, 0)),
                    Label = 1,
                    Status = 1,
                    Accepted = true
                },
                new Appointment {
                    Caption = "New Brochures",
                    StartDate = date + (new TimeSpan(1, 13, 30, 0)),
                    EndDate = date + (new TimeSpan(1, 15, 15, 0)),
                    Label = 8,
                    Status = 2,
                    Accepted = true
                },
                new Appointment {
                    Caption = "Book Flights to San Fran for Sales Trip",
                    StartDate = date + (new TimeSpan(1, 12, 0, 0)),
                    EndDate = date + (new TimeSpan(1, 13, 0, 0)),
                    AllDay = true,
                    Label = 8,
                    Status = 1
                },
                new Appointment {
                    Caption = "Approve Personal Computer Upgrade Plan",
                    StartDate = date + (new TimeSpan(2, 10, 0, 0)),
                    EndDate = date + (new TimeSpan(2, 13, 0, 0)),
                    Label = 8,
                    Status = 2
                },
                new Appointment {
                    Caption = "Final Budget Review",
                    StartDate = date + (new TimeSpan(2, 14, 0, 0)),
                    EndDate = date + (new TimeSpan(2, 16, 30, 0)),
                    Label = 1,
                    Status = 1
                },
                new Appointment {
                    Caption = "Install New Database",
                    StartDate = date + (new TimeSpan(3, 9, 45, 0)),
                    EndDate = date + (new TimeSpan(3, 11, 45, 0)),
                    Label = 6,
                    Status = 4,
                    Accepted = true
                },
                new Appointment {
                    Caption = "Approve New Online Marketing Strategy",
                    StartDate = date + (new TimeSpan(3,  12, 30, 0)),
                    EndDate = date + (new TimeSpan(3, 15, 30, 0)),
                    Label = 1,
                    Status = 1,
                    Accepted = true
                },
                new Appointment {
                    Caption = "Customer Workshop",
                    StartDate = date + (new TimeSpan(4,  11, 0, 0)),
                    EndDate = date + (new TimeSpan(4, 12, 0, 0)),
                    AllDay = true,
                    Label = 8,
                    Status = 1
                },
                new Appointment {
                    Caption = "Prepare 2021 Marketing Plan",
                    StartDate = date + (new TimeSpan(4,  10, 30, 0)),
                    EndDate = date + (new TimeSpan(4, 13, 0, 0)),
                    Label = 1,
                    Status = 1,
                    Accepted = true
                },
                new Appointment {
                    Caption = "Brochure Design Review",
                    StartDate = date + (new TimeSpan(4, 14, 0, 0)),
                    EndDate = date + (new TimeSpan(4, 16, 30, 0)),
                    Label = 1,
                    Status = 2,
                    Accepted = true
                },
                new Appointment {
                    Caption = "Create Icons for Website",
                    StartDate = date + (new TimeSpan(5, 10, 0, 0)),
                    EndDate = date + (new TimeSpan(5, 12, 30, 0)),
                    Label = 1,
                    Status = 1
                },
                new Appointment {
                    Caption = "Launch New Website",
                    StartDate = date + (new TimeSpan(5, 13, 20, 0)),
                    EndDate = date + (new TimeSpan(5, 16, 0, 0)),
                    Label = 8,
                    Status = 1
                },
                new Appointment {
                    Caption = "Upgrade Server Hardware",
                    StartDate = date + (new TimeSpan(6, 11, 0, 0)),
                    EndDate = date + (new TimeSpan(6, 13, 30, 0)),
                    Label = 8,
                    Status = 1
                }
            };
            return dataSource;
        }
    }
}
