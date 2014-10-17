internal class Robot
{
	public string Name { get; private set; }

	public Robot()
	{
		FactoryReset();
	}

	public void FactoryReset()
	{
		var robotNumber = NumberAllocator.Next();
		Name = ToNameFormat(robotNumber);
	}

	private static string ToNameFormat(int robotNumber)
	{
		var nameSection = new string[3];

		nameSection[0] = ((char) ('A' + (robotNumber % 26))).ToString();
		robotNumber /= 26;
		nameSection[1] = ((char) ('A' + (robotNumber % 26))).ToString();
		robotNumber /= 26;
		nameSection[2] = (robotNumber % 1000).ToString().PadLeft(3, '0');

		return string.Concat(nameSection);
	}
}

public static class NumberAllocator
{
	private static int _robotNumber = 0;

	public static int Next()
	{
		return _robotNumber++;
	}
}