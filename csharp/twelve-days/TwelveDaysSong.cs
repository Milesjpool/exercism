using System.Collections.Generic;

public class TwelveDaysSong
{
	private readonly Dictionary<int, string> _toOrdinal = new Dictionary<int, string>
		{
			{1, "first"},
			{2, "second"},
			{3, "third"},
			{4, "fourth"},
			{5, "fifth"},
			{6, "sixth"},
			{7, "seventh"},
			{8, "eighth"},
			{9, "ninth"},
			{10, "tenth"},
			{11, "eleventh"},
			{12, "twelfth"}
		};

	private readonly Dictionary<int, string> _daysGifts = new Dictionary<int, string>
		{
			{1, "a Partridge in a Pear Tree"},
			{2, "two Turtle Doves"},
			{3, "three French Hens"},
			{4, "four Calling Birds"},
			{5, "five Gold Rings"},
			{6, "six Geese-a-Laying"},
			{7, "seven Swans-a-Swimming"},
			{8, "eight Maids-a-Milking"},
			{9, "nine Ladies Dancing"},
			{10, "ten Lords-a-Leaping"},
			{11, "eleven Pipers Piping"},
			{12, "twelve Drummers Drumming"}
		};

	public string Sing()
	{
		return Verses(1, 12);
	}

	public string Verses(int start, int finish)
	{
		var song = string.Empty;
		for (int day = start; day <= finish; day++)
		{
			song += Verse(day) + "\n";
		}
		return song;
	}

	public string Verse(int verseNumber)
	{
		var verseLyrics = "On the " + _toOrdinal[verseNumber] + " day of Christmas my true love gave to me, ";

		for (int day = verseNumber; day >= 1; day--)
		{
			verseLyrics += _daysGifts[day] + GiftDelimeter(day);
		}

		return verseLyrics;
	}

	private static string GiftDelimeter(int day)
	{
		if (day == 1)
			return ".\n";
		if (day == 2)
			return ", and ";
		return ", ";
	}
}