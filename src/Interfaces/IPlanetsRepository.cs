using star_wars_planet_stats.Types;

namespace star_wars_planet_stats.Interfaces;

public interface IPlanetsRepository
{
	public Task<IReadOnlyList<Planet>?> GetStats();
}