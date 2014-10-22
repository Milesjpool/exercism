using System.Collections.Generic;
using System.Linq;

public class Allergies
{
	private readonly List<string> _allergies = new List<string>();

	private readonly List<KeyValuePair<int, string>> _allergens = new List<KeyValuePair<int, string>>
		{
			new KeyValuePair<int, string>(128, "cats"),
			new KeyValuePair<int, string>(64, "pollen"),
			new KeyValuePair<int, string>(32, "chocolate"),
			new KeyValuePair<int, string>(16, "tomatoes"),
			new KeyValuePair<int, string>(8, "strawberries"),
			new KeyValuePair<int, string>(4, "shellfish"),
			new KeyValuePair<int, string>(2, "peanuts"),
			new KeyValuePair<int, string>(1, "eggs"),
		};

	public Allergies(int allergyScore)
	{
		PopulateAllergies(allergyScore);
	}

	private void PopulateAllergies(int allergyScore)
	{
		var ignoreScore = _allergens.First().Key*2;

		foreach (var allergen in _allergens)
		{
			var allergic = (allergyScore % ignoreScore) >= allergen.Key;
			if (allergic)
			{
				_allergies.Add(allergen.Value);
				allergyScore -= allergen.Key;
			}
		}
		_allergies.Reverse();
	}

	public bool AllergicTo(string allergen)
	{
		return _allergies.Contains(allergen);
	}

	public List<string> List()
	{
		return _allergies;
	}
}