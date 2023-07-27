using star_wars_planet_stats.PlanetsDataStructs;

namespace star_wars_planet_stats.Interfaces;

public interface IPrinter
{
	public void PrintPlanetsStats(IReadOnlyList<ValidatedPlanet> planets);
}