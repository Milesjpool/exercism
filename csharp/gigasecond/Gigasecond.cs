using System;

namespace Gigasecond
{
	public class Gigasecond
	{
		public DateTime StartDate { get; private set; }

		public Gigasecond(DateTime startDate)
		{
			StartDate = startDate;
		}

		public DateTime Date()
		{
			const int secondsInDay = 24*60*60;
			var daysInGigasecond = (int) Math.Pow(10,9)/secondsInDay;
			return StartDate.AddDays(daysInGigasecond);
		}
	}
}