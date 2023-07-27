using star_wars_planet_stats.Enums;
using star_wars_planet_stats.Interfaces;
using star_wars_planet_stats.PlanetsDataStructs;

namespace star_wars_planet_stats.Classes;

public class StatsHandler : IStatsHandler
{
	public void HandleUserInput(IReadOnlyList<ValidatedPlanet> planets)
	{
		PrintAvailableOptions();
		
		string? userInput = Console.ReadLine();

		switch (userInput)
		{
			case nameof(StatisticsProperties.Diameter):
				PrintStatsByDiameter(planets);
		
				break;
		
			case nameof(StatisticsProperties.SurfaceWater):
				PrintStatsBySurfaceWater(planets);
		
				break;
		
			case nameof(StatisticsProperties.Population):
				PrintStatsByPopulation(planets);
		
				break;
		
			default:
				Console.WriteLine("Invalid choice");
		
				break;
		}
	}

	public void PrintAvailableOptions()
	{
		Console.WriteLine("The statistics of which property would you like to see?");
		Console.WriteLine("Population");
		Console.WriteLine("Diameter");
		Console.WriteLine("Surface water");
	}

	public void PrintStatsByDiameter(IReadOnlyList<ValidatedPlanet> planets)
	{
		ValidatedPlanet min = planets[0];
		ValidatedPlanet max = planets[0];

		foreach (ValidatedPlanet planet in planets)
		{
			if (planet.Diameter < min.Diameter)
			{
				min = planet;
			}
			
			if (planet.Diameter > max.Diameter)
			{
				max = planet;
			}
		}

		Console.WriteLine($"Max diameter is {max.Diameter} (planet: {max.Name})");
		Console.WriteLine($"Min diameter is {min.Diameter} (planet: {min.Name})");
	}

	public void PrintStatsBySurfaceWater(IReadOnlyList<ValidatedPlanet> planets)
	{
		ValidatedPlanet min = planets[0];
		ValidatedPlanet max = planets[0];

		foreach (ValidatedPlanet planet in planets)
		{
			if (planet.SurfaceWater < min.SurfaceWater)
			{
				min = planet;
			}
			
			if (planet.SurfaceWater > max.SurfaceWater)
			{
				max = planet;
			}
		}

		Console.WriteLine($"Max surface water is {max.SurfaceWater} (planet: {max.Name})");
		Console.WriteLine($"Min surface water is {min.SurfaceWater} (planet: {min.Name})");
	}

	public void PrintStatsByPopulation(IReadOnlyList<ValidatedPlanet> planets)
	{
		ValidatedPlanet min = planets[0];
		ValidatedPlanet max = planets[0];

		foreach (ValidatedPlanet planet in planets)
		{
			if (planet.Population < min.Population)
			{
				min = planet;
			}
			
			if (planet.Population > max.Population)
			{
				max = planet;
			}
		}

		Console.WriteLine($"Max population is {max.Population} (planet: {max.Name})");
		Console.WriteLine($"Min population is {min.Population} (planet: {min.Name})");
	}
}