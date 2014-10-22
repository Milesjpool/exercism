using System;
using System.Linq;

public class Binary
{
	private readonly string _binaryInput;

	public Binary(string binaryInput)
	{
		_binaryInput = binaryInput;
	}

	public int ToDecimal()
	{
		var ascendingInput = ToReversedArray(_binaryInput);

		if (ValidBinary(ascendingInput))
			return SumOverValues(ascendingInput);
		return 0;
	}

	private static int SumOverValues(char[] input)
	{
		var sum = 0;
		for (var i = 0; i < input.Length; i++)
		{
			if (input[i] == '1')
			{
				sum += (int) Math.Pow(2, i);
			}
		}
		return sum;
	}

	private static char[] ToReversedArray(string input)
	{
		var inputArray = input.ToCharArray();
		Array.Reverse(inputArray);
		return inputArray;
	}

	private static bool ValidBinary(char[] input)
	{
		return (input.Count(x => (x == '0' || x == '1')) == input.Count());
	}
}