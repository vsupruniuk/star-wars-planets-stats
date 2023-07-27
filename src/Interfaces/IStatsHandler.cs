using star_wars_planet_stats.PlanetsDataStructs;

namespace star_wars_planet_stats.Interfaces;

public interface IStatsHandler
{
	public void PrintAvailableOptions();
	public void HandleUserInput(IReadOnlyList<ValidatedPlanet> planets);
	public void PrintStatsByPopulation(IReadOnlyList<ValidatedPlanet> planets);
	public void PrintStatsByDiameter(IReadOnlyList<ValidatedPlanet> planets);
	public void PrintStatsBySurfaceWater(IReadOnlyList<ValidatedPlanet> planets);
}