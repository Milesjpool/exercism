using System;
using System.Collections.Generic;

namespace anagram
{
	public class Anagram
	{
		private readonly string _rawInput;
		private readonly string _aplhabetisedInput;

		public Anagram(string inputWord)
		{
			_rawInput = inputWord.ToLower();
			_aplhabetisedInput = SortLetters(_rawInput);
		}

		public object Match(string[] words)
		{
			var matchedWords = new List<string>();

			foreach (var word in words)
			{
				AddWordIfAnagram(word, matchedWords);
			}

			matchedWords.Sort();
			return matchedWords.ToArray();
		}

		private void AddWordIfAnagram(string word, List<string> matchedWords)
		{
			string sortedWord = SortLetters(word.ToLower());
			if ((word.ToLower() != _rawInput) && (sortedWord == _aplhabetisedInput))
			{
				matchedWords.Add(word);
			}
		}

		private string SortLetters(string word)
		{
			var chars = word.ToLower().ToCharArray();
			Array.Sort(chars);
			return new string(chars);
		}
	}
}