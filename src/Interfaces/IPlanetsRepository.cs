using star_wars_planet_stats.PlanetsDataStructs;

namespace star_wars_planet_stats.Interfaces;

public interface IPlanetsRepository
{
	public Task<IReadOnlyList<ValidatedPlanet>?> GetStats();
}