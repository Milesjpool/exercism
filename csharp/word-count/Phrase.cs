using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Phrase
{
	private string[] Input { get; set; }

	public Phrase(string input)
	{
		Input = ParseInput(input);
	}

	private string[] ParseInput(string input)
	{
		input = input.ToLower();
		input = Regex.Replace(input, "[^A-Za-z1-9']", " ");
		input = Regex.Replace(input, " +", " ");
		input = input.TrimStart(' ').TrimEnd(' ');
		return input.Split(' ');
	}

	public object WordCount()
	{
		var wordCount = new Dictionary<string, int>();

		foreach (var word in Input)
		{
			AddWordOrIncrement(word, wordCount);
		}
		return wordCount;
	}

	private static void AddWordOrIncrement(string word, Dictionary<string, int> counts)
	{
		if (!counts.ContainsKey(word))
		{
			counts.Add(word, 1);
		}
		else
		{
			counts[word]++;
		}
	}
}