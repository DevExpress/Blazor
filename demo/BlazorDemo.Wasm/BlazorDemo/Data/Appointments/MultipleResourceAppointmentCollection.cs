using DevExpress.Blazor;
using System.Collections.Generic;
using System;

namespace BlazorDemo.Data {
    public static partial class MultipleResourceAppointmentCollection {
        public static List<Appointment> GetAppointments() {
            DateTime date = DateTime.Now.Date;

            return new List<Appointment>() {
                new Appointment {
                    Id = 0,
                    Accepted = true,
                    Caption = "Install New Router in Dev Room",
                    StartDate = date + (new TimeSpan(0, 10, 0, 0)),
                    EndDate = date + (new TimeSpan(0, 12, 0, 0)),
                    Status = 1,
                    Resources = DxSchedulerResourceIdCollection.ToXml(0)
                },
                new Appointment {
                    Id = 1,
                    Caption = "Upgrade Personal Computers",
                    Accepted = false,
                    StartDate = date + (new TimeSpan(0,  13, 0, 0)),
                    EndDate = date + (new TimeSpan(0, 14, 30, 0)),
                    Status = 2,
                    Resources = DxSchedulerResourceIdCollection.ToXml(0, 1)
                },
                new Appointment {
                    Id = 2,
                    Caption = "Website Redesign Plan",
                    Accepted = false,
                    StartDate = date + (new TimeSpan(1, 9, 30, 0)),
                    EndDate = date + (new TimeSpan(1, 11, 30, 0)),
                    Status = 3,
                    Resources = DxSchedulerResourceIdCollection.ToXml(0, 1, 2)
                },
                new Appointment {
                    Id = 3,
                    Caption = "Approve Personal Computer Upgrade Plan",
                    Accepted = true,
                    StartDate = date + (new TimeSpan(1, 14, 0, 0)),
                    EndDate = date + (new TimeSpan(1, 16, 0, 0)),
                    Status = 2,
                    Resources = DxSchedulerResourceIdCollection.ToXml(1, 2)
                },
            };
        }
    }
}
