using System.Collections.Generic;
using System.Linq;

internal class SumOfMultiples
{
	private readonly List<int> _divisors = new List<int> {3, 5};

	public SumOfMultiples(List<int> arg = null)
	{
		if (arg != null)
			_divisors = arg;
	}

	public object To(int upperLimit)
	{
		var sum = 0;

		for (var i = 0; i < upperLimit; i++)
		{
			sum += AddIfDivisible(i);
		}
		return sum;
	}

	private int AddIfDivisible(int i)
	{
		if (_divisors.Any(divisor => i%divisor == 0))
			return i;
		return 0;
	}
}