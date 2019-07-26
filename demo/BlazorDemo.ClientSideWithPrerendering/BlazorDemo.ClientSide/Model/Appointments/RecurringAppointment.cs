using System;
using System.Collections.Generic;
using System.Drawing;

namespace Demo.Blazor.Model {
    public static partial class RecurringAppointmentCollection {

        public class RecurringAppointment {
            public RecurringAppointment() {}

            public int AppointmentId { get; set; }
            public int AppointmentType { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Caption { get; set; }
            public int Label { get; set; }
            public bool AllDay { get; set; }
            public string Recurrence { get; set; }
        }

    }
}
