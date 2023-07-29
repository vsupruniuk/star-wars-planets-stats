using star_wars_planet_stats.Interfaces;
using star_wars_planet_stats.Types;

namespace star_wars_planet_stats.Classes;

public class StatsHandler : IStatsHandler
{
	public void PrintStatsByProperty(IReadOnlyList<Planet> planets, string property, Func<Planet, long?> findBy)
	{
		Planet min = planets.MinBy(findBy);
		Planet max = planets.MaxBy(findBy);

		Console.WriteLine($"Max {property} is {findBy(max)} (planet: {max.Name})");
		Console.WriteLine($"Min {property} is {findBy(min)} (planet: {min.Name})");
	}
}