using System.Collections.Generic;

public class SpaceAge
{
	public long Seconds { get; private set; }

	private readonly IDictionary<string, double> planetYearInEarthYears = new Dictionary<string, double>()
		{
			{"Mercury", 0.2408467f},
			{"Venus", 0.61519726f},
			{"Mars", 1.8808158f},
			{"Jupiter", 11.862615f},
			{"Saturn", 29.447498f},
			{"Uranus", 84.016846f},
			{"Neptune", 164.79132f}
		};

	public SpaceAge(long seconds)
	{
		Seconds = seconds;
	}

	public double OnEarth()
	{
		const double secondsPerYear = 31557600;
		return Seconds/secondsPerYear;
	}

	public double OnMercury()
	{
		return OnEarth()/planetYearInEarthYears["Mercury"];
	}

	public double OnVenus()
	{
		return OnEarth() / planetYearInEarthYears["Venus"];
	}

	public object OnMars()
	{
		return OnEarth() / planetYearInEarthYears["Mars"];
	}

	public object OnJupiter()
	{
		return OnEarth() / planetYearInEarthYears["Jupiter"];
	}

	public object OnSaturn()
	{
		return OnEarth() / planetYearInEarthYears["Saturn"];
	}

	public object OnUranus()
	{
		return OnEarth() / planetYearInEarthYears["Uranus"];
	}

	public object OnNeptune()
	{
		return OnEarth() / planetYearInEarthYears["Neptune"];
	}
}