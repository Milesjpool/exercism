using System.Collections.Generic;

internal class School
{
	public Dictionary<int, List<string>> Roster { get; private set; }

	public School()
	{
		Roster = new Dictionary<int, List<string>>();
	}

	public void Add(string name, int grade)
	{
		if (!Roster.ContainsKey(grade))
		{
			Roster.Add(grade, new List<string>());
		}
		Roster[grade].Add(name);
		Roster[grade].Sort();

	}

	public List<string> Grade(int grade)
	{
		if (!Roster.ContainsKey(grade))
		{
			Roster.Add(grade, new List<string>());
		}
		return Roster[grade];
	}
}