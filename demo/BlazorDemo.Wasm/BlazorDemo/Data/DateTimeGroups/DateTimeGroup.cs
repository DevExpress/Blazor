using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BlazorDemo.Data {
    public enum DateTimeGroupType { Year, Month, Week, Day }

    public class DateTimeGroup {
        public DateTimeGroup(DateTime dateTime, DateTimeGroupType groupType) {
            DateTime = dateTime;
            GroupType = groupType;
        }

        public DateTime DateTime { get; private set; }
        public DateTimeGroupType GroupType { get; private set; }
        public string Title {
            get {
                switch(GroupType) {
                    case DateTimeGroupType.Year:
                        return DateTime.ToString("yyyy");
                    case DateTimeGroupType.Month:
                        return DateTime.ToString("MMMM");
                    case DateTimeGroupType.Week:
                        var culture = CultureInfo.CurrentCulture;
                        var weekNumber = culture.Calendar.GetWeekOfYear(DateTime,
                            culture.DateTimeFormat.CalendarWeekRule,
                            culture.DateTimeFormat.FirstDayOfWeek);
                        var weekStartDate = DateTimeUtils.GetWeekStart(DateTime);
                        var weekEndDate = weekStartDate.AddDays(6);
                        var formatString = weekStartDate.Year == weekEndDate.Year ? "MMMM d" : "MMMM d, yyyy";
                        return String.Format("Week {0} ({1} - {2})", weekNumber,
                            weekStartDate.ToString(formatString), weekEndDate.ToString(formatString));
                    case DateTimeGroupType.Day:
                        return DateTime.ToString("dddd, MMMM d");
                    default:
                        return "";
                }
            }
        }
        public bool HasSubGroups => GroupType < DateTimeGroupType.Day;
        IEnumerable<DateTimeGroup> subGroups;
        public IEnumerable<DateTimeGroup> SubGroups => subGroups ??= GetSubGroups();
        public IEnumerable<DateTimeGroup> GetSubGroups() {
            switch(GroupType) {
                case DateTimeGroupType.Year:
                    return Enumerable.Range(1, 12)
                        .Select(m => new DateTimeGroup(new DateTime(DateTime.Year, m, 1), DateTimeGroupType.Month))
                        .ToList();
                case DateTimeGroupType.Month:
                    var firstDayOfMonth = DateTime;
                    var weekOffset = firstDayOfMonth.Month > 1 ? firstDayOfMonth.DayOfWeek - CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek : 0;
                    var day = firstDayOfMonth.AddDays(-weekOffset);
                    var nextMonthFirstDay = DateTime.AddMonths(1);
                    var monthWeeks = new List<DateTimeGroup>();
                    while(day < nextMonthFirstDay) {
                        monthWeeks.Add(new DateTimeGroup(day.Month == firstDayOfMonth.Month ? day : firstDayOfMonth, DateTimeGroupType.Week));
                        for(int i = 0; i < 7; i++)
                            day = day.AddDays(1);
                    }
                    return monthWeeks;
                case DateTimeGroupType.Week:
                    var firstDayOfWeek = DateTimeUtils.GetWeekStart(DateTime);
                    var dayOfWeek = firstDayOfWeek;
                    var weekDays = new List<DateTimeGroup>();
                    for(int i = 0; i < 7; i++) {
                        if(dayOfWeek.Year == DateTime.Year && dayOfWeek.Month == DateTime.Month)
                            weekDays.Add(new DateTimeGroup(dayOfWeek, DateTimeGroupType.Day));
                        dayOfWeek = dayOfWeek.AddDays(1);
                    }
                    return weekDays;
                default:
                    return null;
            }
        }
    }
}
