using star_wars_planet_stats.Interfaces;
using star_wars_planet_stats.PlanetsDataStructs;

namespace star_wars_planet_stats.Classes;

public class Printer : IPrinter
{
	private const int TableGap = -20;
	private const int Columns = 4;

	public void PrintPlanetsStats(IReadOnlyList<ValidatedPlanet> planets)
	{
		Console.WriteLine($"{"Name",TableGap}|{"Diameter",TableGap}|{"Surface Water",TableGap}|{"Population",TableGap}|");
		Console.WriteLine(new string('-', TableGap * Columns * -1 + Columns));

		foreach (ValidatedPlanet planet in planets)
		{
			// TODO check for invalid data
			Console.WriteLine(
				$"{planet.Name,TableGap}|{planet.Diameter,TableGap}|{planet.SurfaceWater,TableGap}|{planet.Population,TableGap}|");
		}
	}
}