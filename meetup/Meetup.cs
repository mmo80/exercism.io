using System;

public enum Schedule
{
    Teenth = -1,
    First = 0,
    Second = 1,
    Third = 2,
    Fourth = 3,
    Last = 4
}

public class Meetup
{
    private readonly DateTime _date;

    public Meetup(int month, int year) => _date = Convert.ToDateTime($"{year}-{month}-01");

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule) => GetDate(dayOfWeek, schedule);

    private DateTime GetDate(DayOfWeek dayOfWeek, Schedule schedule)
    {
        var o = 0;
        int occurrence = (int)schedule;
        var daysInMonth = DateTime.DaysInMonth(_date.Year, _date.Month);

        if (schedule == Schedule.Teenth)
            foreach (var i in new[] { 13, 14, 15, 16, 17, 18, 19 })
            {
                var check = new DateTime(_date.Year, _date.Month, i);
                if (check.DayOfWeek == dayOfWeek) return check;
            }

        if (schedule == Schedule.Last)
            for (int i = daysInMonth; i > 0; i--)
            {
                var check = new DateTime(_date.Year, _date.Month, i);
                if (check.DayOfWeek == dayOfWeek) return check;
            }

        for (int n = 1; n <= daysInMonth; n++)
        {
            var check = new DateTime(_date.Year, _date.Month, n);
            if (check.DayOfWeek != dayOfWeek) continue;
            if (o == occurrence) return check;
            o++;
        }

        return DateTime.Now;
    }
}