using System;
using System.Collections.Generic;

namespace BlazorDemo.Data {
    class CalendarData {
        public CalendarData() {
            DateTime baseDate = DateTime.Today;
            PersonalDays = GetPersonalDays(baseDate);
            Holidays = GetHolidays(baseDate);
            BirthDates = GetBirthDates(baseDate);
        }

        public List<DateTime> PersonalDays { get; }
        public List<DateTime> Holidays { get; }
        public List<DateTime> BirthDates { get; }

        List<DateTime> GetPersonalDays(DateTime baseDate) {
            return new List<DateTime>() {
                    baseDate.AddDays(-7),
                    baseDate.AddDays(-2),
                    baseDate.AddDays(-1),
                    baseDate.AddDays(3),
                    baseDate.AddDays(4),
                    baseDate.AddDays(9),
                    baseDate.AddDays(10),
                    baseDate.AddDays(12),
                    baseDate.AddDays(15)
            };
        }

        List<DateTime> GetHolidays(DateTime baseDate) {
            return new List<DateTime>() {
                    baseDate.AddDays(-14),
                    baseDate.AddDays(-8),
                    baseDate.AddDays(12),
                    baseDate.AddDays(13)
            };
        }

        List<DateTime> GetBirthDates(DateTime baseDate) {
            return new List<DateTime>() {
                    baseDate.AddDays(-20),
                    baseDate.AddDays(-5),
                    baseDate,
                    baseDate.AddDays(1),
                    baseDate.AddDays(6),
                    baseDate.AddDays(7),
                    baseDate.AddDays(17)
            };
        }
    }
}
