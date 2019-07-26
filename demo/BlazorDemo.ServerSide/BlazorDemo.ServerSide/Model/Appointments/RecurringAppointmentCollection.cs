using System;
using System.Collections.Generic;
using System.Drawing;

namespace Demo.Blazor.Model {

    public static partial class RecurringAppointmentCollection {

        private static readonly Lazy<List<RecurringAppointment>> appointments = new Lazy<List<RecurringAppointment>>(() => {
            DateTime date = DateTimeUtils.CreateWeekStart();
            return new List<RecurringAppointment>() {
                new RecurringAppointment {
                    AppointmentId = 1,
                    AppointmentType = 1,
                    Caption = "Watercolor Landscape",
                    Label = 1,
                    StartDate = date + (new TimeSpan(2, 9, 30, 0)),
                    EndDate = date + (new TimeSpan(2, 11, 0, 0)),
                    Recurrence = string.Format("<RecurrenceInfo Start=\"{0}\" End=\"{1}\" WeekDays=\"36\" Id=\"04dcc127-df56-49d7-baff-ce4b6264addd\" OccurrenceCount=\"10\" Range=\"1\" Type=\"1\" />", date + (new TimeSpan(2, 9, 30, 0)), date + (new TimeSpan(2, 11, 0, 0)))
                },
                new RecurringAppointment {
                    AppointmentId = 2,
                    AppointmentType = 1,
                    Caption = "Oil Painting for Beginners",
                    Label = 2,
                    StartDate = date + (new TimeSpan(1, 9, 30, 0)),
                    EndDate = date + (new TimeSpan(1, 11, 0, 0)),
                    Recurrence = string.Format("<RecurrenceInfo Start=\"{0}\" End=\"{1}\" WeekDays=\"18\" Id=\"72e3db8f-cdb6-4aaa-afe1-e3c6b80ce99e\" OccurrenceCount=\"10\" Range=\"1\" Type=\"1\" />", date + (new TimeSpan(1, 9, 30, 0)), date + (new TimeSpan(1, 11, 0, 0)))
                },
                new RecurringAppointment {
                    AppointmentId = 3,
                    AppointmentType = 1,
                    Caption = "Testing",
                    Label = 3,
                    StartDate = date + (new TimeSpan(1, 12, 0, 0)),
                    EndDate = date + (new TimeSpan(1, 13, 0, 0)),
                    Recurrence = string.Format("<RecurrenceInfo Start=\"{0}\" End=\"{1}\" WeekDays=\"2\" Id=\"15129fd3-9eb0-4861-8c43-c61844137f17\" OccurrenceCount=\"2\" Periodicity=\"2\" Range=\"1\" Type=\"1\" />", date + (new TimeSpan(1, 12, 0, 0)), date + (new TimeSpan(1, 13, 0, 0)))
                },
                new RecurringAppointment {
                    AppointmentId = 4,
                    AppointmentType = 1,
                    Caption = "Meeting of Instructors",
                    Label = 4,
                    StartDate = date + (new TimeSpan(1, 9, 0, 0)),
                    EndDate = date + (new TimeSpan(1, 9, 15, 0)),
                    Recurrence = string.Format("<RecurrenceInfo Start=\"{0}\" End=\"{1}\" WeekDays=\"62\" Id=\"6de79b21-6b16-4dea-9736-c500058ec858\" OccurrenceCount=\"25\" Range=\"1\" />", date + (new TimeSpan(1, 9, 0, 0)), date + (new TimeSpan(1, 9, 15, 0)))
                },
                new RecurringAppointment {
                    AppointmentId = 5,
                    AppointmentType = 1,
                    Caption = "Monthly Planning",
                    Label = 4,
                    StartDate = date + (new TimeSpan(3, 14, 30, 0)),
                    EndDate = date + (new TimeSpan(3, 15, 45, 0)),
                    Recurrence = string.Format("<RecurrenceInfo Start=\"{0}\" End=\"{1}\" DayNumber=\"24\" WeekOfMonth=\"0\" Id=\"cd9da802-d166-47d1-a8df-1101fcc50d53\" OccurrenceCount=\"2\" Range=\"1\" Type=\"2\" />", date + (new TimeSpan(3, 14, 30, 0)), date + (new TimeSpan(3, 15, 45, 0)))
                },
                new RecurringAppointment {
                    AppointmentId = 6,
                    AppointmentType = 1,
                    Caption = "Annual Open Day",
                    Label = 5,
                    StartDate = date + (new TimeSpan(27, 9, 30, 0)),
                    EndDate = date + (new TimeSpan(27, 13, 0, 0)),
                    Recurrence = string.Format("<RecurrenceInfo Start=\"{0}\" Month=\"{1}\" DayNumber=\"{2}\" WeekOfMonth=\"0\" Id=\"bd5dc726-0fa6-4965-99e0-bf69063218e6\" Type=\"3\" />", date + (new TimeSpan(27, 9, 30, 0)), (date + (new TimeSpan(27, 9, 30, 0))).Month, (date + (new TimeSpan(27, 9, 30, 0))).Day)
                }
            };
        });

        public static List<RecurringAppointment> DataSource { get { return appointments.Value; } }
    }
}
