internal class Robot
{
	public string Name { get; private set; }

	public Robot()
	{
		FactoryReset();
	}

	public void FactoryReset()
	{
		var nameValue = NumberAllocator.Next();
		Name = ToNameFormat(nameValue);
	}

	private static string ToNameFormat(int nameValue)
	{
		var nameSections = new string[3];

		nameSections[0] = ((char) ('A' + (nameValue % 26))).ToString();
		nameValue /= 26;
		nameSections[1] = ((char) ('A' + (nameValue % 26))).ToString();
		nameValue /= 26;
		nameSections[2] = (nameValue % 1000).ToString().PadLeft(3, '0');

		return nameSections[0] + nameSections[1] + nameSections[2];
	}
}

public static class NumberAllocator
{
	private static int current = 0;

	public static int Next()
	{
		var x = current;
		current++;
		return x;
	}
}