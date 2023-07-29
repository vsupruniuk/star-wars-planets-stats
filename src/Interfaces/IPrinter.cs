using star_wars_planet_stats.Types;

namespace star_wars_planet_stats.Interfaces;

public interface IPrinter
{
	public void PrintPlanetsStats(IReadOnlyList<Planet> planets);
}