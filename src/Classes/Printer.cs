using star_wars_planet_stats.Interfaces;
using star_wars_planet_stats.Types;

namespace star_wars_planet_stats.Classes;

public class Printer : IPrinter
{
	private const int TableGap = -20;
	private const int Columns = 4;

	public void PrintPlanetsStats(IReadOnlyList<Planet> planets)
	{
		Console.WriteLine($"{"Name",TableGap}|{"Diameter",TableGap}|{"Surface Water",TableGap}|{"Population",TableGap}|");
		Console.WriteLine(new string('-', TableGap * Columns * -1 + Columns));

		foreach (Planet planet in planets)
		{
			Console.WriteLine(
				$"{planet.Name,TableGap}|{planet.Diameter,TableGap}|{planet.SurfaceWater,TableGap}|{planet.Population,TableGap}|");
		}

		Console.WriteLine();
	}
}