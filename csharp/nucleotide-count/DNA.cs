using System.Collections.Generic;
using System.Linq;

public class DNA
{
	public IDictionary<char, int> NucleotideCounts { get; private set; }

	public DNA(string dnaString)
	{
		NucleotideCounts = new Dictionary<char, int> { { 'A', 0 }, { 'T', 0 }, { 'C', 0 }, { 'G', 0 } };

		foreach (var nucleotide in dnaString.Where(nucleotide => NucleotideCounts.ContainsKey(nucleotide)))
		{
			NucleotideCounts[nucleotide]++;
		}
	}

	public int Count(char nucleotide)
	{
		if (!NucleotideCounts.ContainsKey(nucleotide))
		{
			throw new InvalidNucleotideException();
		}
		return NucleotideCounts[nucleotide];
	}
}

public class InvalidNucleotideException : KeyNotFoundException {}
