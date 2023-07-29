using star_wars_planet_stats.Types;

namespace star_wars_planet_stats.Interfaces;

public interface IStatsHandler
{
	public void PrintStatsByProperty(IReadOnlyList<Planet> planets, string property, Func<Planet, long?> findBy);
}