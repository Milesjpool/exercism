using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ScrabbleScore
{
	public class Scrabble
	{
		private static string _input;
		private static readonly IDictionary<char, int> _scoreOf = new Dictionary<char, int>
			{
				{'A', 1}, {'B', 3}, {'C', 3}, {'D', 2}, {'E', 1}, {'F', 4}, {'G', 2}, {'H', 4}, {'I', 1},
				{'J', 8}, {'K', 5}, {'L', 1}, {'M', 3}, {'N', 1}, {'O', 1}, {'P', 3}, {'Q', 10}, {'R', 1},
				{'S', 1}, {'T', 1}, {'U', 1}, {'V', 4}, {'W', 4}, {'X', 8}, {'Y', 4}, {'Z', 10}
			};

		public Scrabble(string input)
		{
			_input = input;
		}

		public int Score()
		{
			return Score(_input);
		}

		public static int Score(string input)
		{
			var word = Parse(input);
			return word.Sum(letter => _scoreOf[letter]);
		}

		private static string Parse(string input)
		{
			var nonChars = new Regex("[^A-Z]");
			return (input == null) ? "" : nonChars.Replace(input.ToUpper(), string.Empty);
		}
	}
}