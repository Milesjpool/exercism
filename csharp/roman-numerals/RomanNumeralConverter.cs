using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals
{
	public static class RomanNumeralConverter
	{
		private static readonly IDictionary<int, string> _numeralDictionary = new Dictionary<int, string>
			{
				{1, "I"},
				{4, "IV"},
				{5, "V"},
				{9, "IX"},
				{10, "X"},
				{40, "XL"},
				{50, "L"},
				{90, "XC"},
				{100, "C"},
				{400, "CD"},
				{500, "D"},
				{900, "CM"},
				{1000, "M"}
			};

		public static string ToRoman(this int decimalInput)
		{
			var romanOutput = string.Empty;

			foreach (var numeralValue in _numeralDictionary.Keys.Reverse())
			{
				while (numeralValue <= decimalInput)
				{
					decimalInput -= numeralValue;
					romanOutput += _numeralDictionary[numeralValue];
				}
			}

			return romanOutput;
		}
	}
}