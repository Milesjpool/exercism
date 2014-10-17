using System;

namespace Meetup
{

	public abstract class Schedule
	{
		public static int Teenth { get { return 0; } }

		public static int First { get { return 1; } }

		public static int Second { get { return 2; } }

		public static int Third { get { return 3; } }

		public static int Fourth { get { return 4; } }

		public static int Last { get { return 5; } }
	}

	public class Meetup
	{
		private int Month { get; set; }
		private int Year { get; set; }

		public Meetup(int month, int year)
		{
			Month = month;
			Year = year;
		}

		public DateTime Day(DayOfWeek dayOfWeek, int schedule)
		{
			if (schedule == Schedule.Teenth)
			{
				return GetTeenth(dayOfWeek);
			}
			if ((schedule >= 1) && (schedule <= 4))
			{
				return GetNth(dayOfWeek, schedule);
			}
			if (schedule == Schedule.Last)
			{
				return GetLast(dayOfWeek);
			}
			return new DateTime();
		}

		private DateTime GetTeenth(DayOfWeek day)
		{
			return GetNextMatchingDay(day, new DateTime(Year, Month, 13));
		}

		private DateTime GetNth(DayOfWeek day, int n)
		{
			var meetup = new DateTime(Year, Month, 1);
			meetup = GetNextMatchingDay(day, meetup);
			return meetup.AddDays(7*(n-1));
		}

		private DateTime GetLast(DayOfWeek day)
		{
			var meetup = new DateTime(Year, Month, DateTime.DaysInMonth(Year, Month));
			return GetNextMatchingDay(day, meetup, -1);
		}

		private static DateTime GetNextMatchingDay(DayOfWeek day, DateTime meetup, int increment = 1)
		{
			while (meetup.DayOfWeek != day)
			{
				meetup = meetup.AddDays(increment);
			}
			return meetup;
		}
	}
}