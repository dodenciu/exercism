using System;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private readonly DateTime _initialMeetupDateDetails;

    public Meetup(int month, int year) => _initialMeetupDateDetails = new DateTime(year, month, 1);

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        if (schedule == Schedule.Teenth)
        {
            return TenthOfMonthHanler(dayOfWeek);
        }

        if (schedule == Schedule.Last)
        {
            return LastDayOfMonthHanler(dayOfWeek);
        }

        return SomeDayOfMonthHanler(dayOfWeek, schedule);        
    }

    private DateTime TenthOfMonthHanler(DayOfWeek dayOfWeek)
    {
        var teenths = new int[] { 13, 14, 15, 16, 17, 18, 19 };
        foreach (var day in teenths)
        {
            var possibleMeetupDay = _initialMeetupDateDetails.AddDays(day - 1);
            if (possibleMeetupDay.DayOfWeek == dayOfWeek)
            {
                return possibleMeetupDay;
            }
        }

        throw new ArgumentOutOfRangeException($"Unable to find teenth for {dayOfWeek}");
    }

    private DateTime LastDayOfMonthHanler(DayOfWeek dayOfWeek)
    {
        var daysInMonth = DateTime.DaysInMonth(_initialMeetupDateDetails.Year, _initialMeetupDateDetails.Month);
        for (int day = daysInMonth; day > daysInMonth - 7; day--)
        {
            var possibleMeetupDay = _initialMeetupDateDetails.AddDays(day - 1);
            if (possibleMeetupDay.DayOfWeek == dayOfWeek)
            {
                return possibleMeetupDay;
            }
        }

        throw new ArgumentOutOfRangeException($"Unable to find {dayOfWeek}");
    }

    private DateTime SomeDayOfMonthHanler(DayOfWeek dayOfWeek, Schedule schedule)
    {
        var startingDay = 7 * ((int)schedule - 1);
        for (var day = startingDay; day < startingDay + 7; day++)
        {
            var possibleMeetupDay = _initialMeetupDateDetails.AddDays(day);
            if (possibleMeetupDay.DayOfWeek == dayOfWeek)
            {
                return possibleMeetupDay;
            }
        }

        throw new ArgumentOutOfRangeException($"Unable to find {schedule} of {dayOfWeek}");
    }

   
}