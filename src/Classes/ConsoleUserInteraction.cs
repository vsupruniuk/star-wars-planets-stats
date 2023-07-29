using star_wars_planet_stats.Interfaces;
using star_wars_planet_stats.Types;

namespace star_wars_planet_stats.Classes;

public class ConsoleUserInteraction : IUserInteraction
{
	private readonly IStatsHandler _statsHandler;
	private readonly Dictionary<string, Func<Planet, long?>> _userInputHandlers =
		new()
		{
			["Population"] = planet => planet.Population,
			["Diameter"] = planet => planet.Diameter,
			["Surface water"] = planet => planet.SurfaceWater,
		};

	public ConsoleUserInteraction(IStatsHandler statsHandler)
	{
		_statsHandler = statsHandler;
	}
	
	public void HandleUserInput(IReadOnlyList<Planet> planets)
	{
		PrintAvailableOptions();

		string? userInput = Console.ReadLine();

		if (userInput is null || !_userInputHandlers.ContainsKey(userInput))
		{
			Console.WriteLine("Invalid Choice");
		}
		else
		{
			_statsHandler.PrintStatsByProperty(planets, userInput, _userInputHandlers[userInput]);
		}
	}

	public void PrintAvailableOptions()
	{
		Console.WriteLine("The statistics of which property would you like to see?");
		Console.WriteLine("Population");
		Console.WriteLine("Diameter");
		Console.WriteLine("Surface water");
		Console.WriteLine();
	}
}