namespace LeapYear
{
	public class Year
	{
		public static bool IsLeap(int year)
		{

			var isDivisibleByFourHundred = (year%400 == 0);
			var isNotDivisibleByOneHundred = (year%100 != 0);
			var isDivisibleByFour = (year%4 == 0);

			return (isDivisibleByFour && isNotDivisibleByOneHundred) || isDivisibleByFourHundred;
		}
	}
}