using star_wars_planet_stats.Types;

namespace star_wars_planet_stats.Interfaces;

public interface IUserInteraction
{
	public void PrintAvailableOptions();
	public void HandleUserInput(IReadOnlyList<Planet> planets);
}