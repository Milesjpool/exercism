using System;
using System.Collections.Generic;

public class PrimeFactors
{
	public static int[] For(long input)
	{
		var factors = new List<int>();

		var prime = new Prime();
		while (input > 1)
		{
			if (input % prime.Current == 0)
			{
				factors.Add(prime.Current);
				input = input / prime.Current;
			}
			else
			{
				prime.Next();
			}
		}
		return factors.ToArray();
	}
}

public class Prime
{
	public int Current { get; private set; }

	public Prime()
	{
		Current = 2;
	}

	public void Next()
	{
		var next = Current;
		do
		{
			next++;
		} while (!IsPrime(next));
		Current = next;
	}

	private static bool IsPrime(int num)
	{
		for (var i = 2; i < Math.Sqrt(num); i++)
		{
			if (num % i == 0) return false;
		}
		return true;
	}
}