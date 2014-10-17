using System;
using System.Collections.Generic;
using System.Linq;


public enum TriangleKind
{
	Equilateral,
	Isosceles,
	Scalene
};

public class TriangleException : Exception
{
}

public class Triangle
{
	private List<decimal> sides;

	public Triangle(decimal sideA, decimal sideB, decimal sideC)
	{
		sides = new List<decimal> {sideA, sideB, sideC};
		sides.Sort();

		if (sides.ElementAt(2) >= (sides.ElementAt(1) + sides.ElementAt(0)))
			throw new TriangleException();
	}

	public Enum Kind()
	{
		if (sides.First() == sides.Last())
			return TriangleKind.Equilateral;
		if (sides.Distinct().Count() < sides.Count())
			return TriangleKind.Isosceles;
		return TriangleKind.Scalene;
	}
}