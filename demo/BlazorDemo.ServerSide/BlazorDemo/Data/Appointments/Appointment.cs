using System;

namespace BlazorDemo.Data {
    public static partial class AppointmentCollection {

        public class Appointment {
            public Appointment() {}

            public int AppointmentType { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Caption { get; set; }
            public string Description { get; set; }
            public string Location { get; set; }
            public int Label { get; set; }
            public int Status { get; set; }
            public bool AllDay { get; set; }
            public string Recurrence { get; set; }
        }

    }
}
