using star_wars_planet_stats.DTOs;
using star_wars_planet_stats.Types;

namespace star_wars_planet_stats.Interfaces;

public interface IPlanetValidator
{
	public IReadOnlyList<Planet>? ValidatedPlanets(StatsResultDTO statsResult);
}