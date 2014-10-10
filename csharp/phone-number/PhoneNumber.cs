using System.Text.RegularExpressions;

public class PhoneNumber
{
	private const string Errornum = "0000000000";

	public string Number { get; private set; }

	public string AreaCode { get {return Number.Substring(0, 3);} }


	public PhoneNumber(string number)
	{
		number = StripNonNumerals(number);

		if (Valid(number))
		{
			Number = RemoveCountryCodeIfPresent(number);
		}
		else
		{
			Number = Errornum;
		}
	}

	private static bool Valid(string number)
	{
		return (number.Length == 10) || ((number.Length == 11) && number.StartsWith("1"));
	}

	private static string RemoveCountryCodeIfPresent(string number)
	{
		if (number.Length != 11) return number;
		return number.Remove(0, 1);
	}

	private string StripNonNumerals(string number)
	{
		var numberCleaner = new Regex("[^0-9]");
		return numberCleaner.Replace(number, "");
	}

	public override string ToString()
	{
		var numberSections = new string[3];
		numberSections[0] = Number.Substring(0, 3);
		numberSections[1] = Number.Substring(3, 3);
		numberSections[2] = Number.Substring(6);
		return "(" + numberSections[0] + ") " + numberSections[1] + "-" + numberSections[2];
	}
}