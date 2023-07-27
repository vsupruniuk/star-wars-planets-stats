using star_wars_planet_stats.PlanetsDataStructs;

namespace star_wars_planet_stats.Interfaces;

public interface IPlanetValidator
{
	public IReadOnlyList<ValidatedPlanet>? ValidatedPlanets(StatsResult statsResult);
}