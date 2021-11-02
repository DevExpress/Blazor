using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace BlazorDemo.Data {

    public static partial class RecurringAppointmentCollection {
        public static List<Appointment> GetAppointments() {
            DateTime date = DateTimeUtils.GetBeginOfMonth(DateTime.Now);
            date = DateTimeUtils.GetWeekStart(date);
            return new List<Appointment>() {
                new Appointment {
                    AppointmentType = 1,
                    Caption = "Watercolor Landscape",
                    Label = 5,
                    StartDate = date + (new TimeSpan(2, 13, 0, 0)),
                    EndDate = date + (new TimeSpan(2, 14, 30, 0)),
                    Recurrence = string.Format("<RecurrenceInfo Start=\"{0}\" End=\"{1}\" WeekDays=\"36\" Id=\"04dcc127-df56-49d7-baff-ce4b6264addd\" OccurrenceCount=\"10\" Range=\"1\" Type=\"1\" />", ToString(date + (new TimeSpan(2, 13, 0, 0))), ToString(date + (new TimeSpan(2, 14, 30, 0)))),
                    ResourceId = 0
                },
                new Appointment {
                    AppointmentType = 1,
                    Caption = "Oil Painting for Beginners",
                    Label = 2,
                    StartDate = date + (new TimeSpan(1, 12, 0, 0)),
                    EndDate = date + (new TimeSpan(1, 13, 30, 0)),
                    Recurrence = string.Format("<RecurrenceInfo Start=\"{0}\" End=\"{1}\" WeekDays=\"18\" Id=\"72e3db8f-cdb6-4aaa-afe1-e3c6b80ce99e\" OccurrenceCount=\"10\" Range=\"1\" Type=\"1\" />", ToString(date + (new TimeSpan(1, 12, 0, 0))), ToString(date + (new TimeSpan(1, 13, 30, 0)))),
                    ResourceId = 0
                },
                new Appointment {
                    AppointmentType = 1,
                    Caption = "Testing",
                    Label = 8,
                    StartDate = date + (new TimeSpan(1, 14, 0, 0)),
                    EndDate = date + (new TimeSpan(1, 15, 0, 0)),
                    Recurrence = string.Format("<RecurrenceInfo Start=\"{0}\" End=\"{1}\" WeekDays=\"2\" Id=\"15129fd3-9eb0-4861-8c43-c61844137f17\" OccurrenceCount=\"2\" Frequency=\"2\" Range=\"1\" Type=\"1\" />", ToString(date + (new TimeSpan(1, 14, 0, 0))), ToString(date + (new TimeSpan(1, 15, 0, 0)))),
                    ResourceId = 1
                },
                new Appointment {
                    AppointmentType = 1,
                    Caption = "Meeting of Instructors",
                    Label = 1,
                    StartDate = date + (new TimeSpan(1, 10, 0, 0)),
                    EndDate = date + (new TimeSpan(1, 10, 45, 0)),
                    Recurrence = string.Format("<RecurrenceInfo Start=\"{0}\" End=\"{1}\" WeekDays=\"62\" Id=\"6de79b21-6b16-4dea-9736-c500058ec858\" OccurrenceCount=\"25\" Range=\"1\" Type=\"1\" />", ToString(date + (new TimeSpan(1, 10, 0, 0))), ToString(date + (new TimeSpan(1, 10, 45, 0)))),
                    ResourceId = 1
                },
                new Appointment {
                    AppointmentType = 1,
                    Caption = "Monthly Planning",
                    Label = 1,
                    StartDate = date + (new TimeSpan(3, 16, 0, 0)),
                    EndDate = date + (new TimeSpan(3, 17, 0, 0)),
                    Recurrence = string.Format("<RecurrenceInfo Start=\"{0}\" End=\"{1}\" DayNumber=\"24\" WeekOfMonth=\"0\" Id=\"cd9da802-d166-47d1-a8df-1101fcc50d53\" OccurrenceCount=\"2\" Range=\"1\" Type=\"2\" />", ToString(date + (new TimeSpan(3, 16, 0, 0))), ToString(date + (new TimeSpan(3, 17, 0, 0)))),
                    ResourceId = 2
                },
                new Appointment {
                    AppointmentType = 1,
                    Caption = "Annual Open Day",
                    Label = 6,
                    StartDate = date + (new TimeSpan(27, 10, 30, 0)),
                    EndDate = date + (new TimeSpan(27, 14, 0, 0)),
                    Recurrence = string.Format("<RecurrenceInfo Start=\"{0}\" Month=\"{1}\" DayNumber=\"{2}\" WeekOfMonth=\"0\" Id=\"bd5dc726-0fa6-4965-99e0-bf69063218e6\" Type=\"3\" />", ToString(date + (new TimeSpan(27, 10, 30, 0))), (date + (new TimeSpan(27, 10, 30, 0))).Month, (date + (new TimeSpan(27, 10, 30, 0))).Day),
                    ResourceId = 3
                }
            };
        }
        private static string ToString(DateTime dateTime) {
            return dateTime.ToString(CultureInfo.InvariantCulture);
        }
    }
}
