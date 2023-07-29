using star_wars_planet_stats.Interfaces;
using star_wars_planet_stats.Types;

namespace star_wars_planet_stats.Classes;

public class PlanetsStats : IPlanetsStats
{
	private readonly IPlanetsRepository _planetsRepository;
	private readonly IPrinter _printer;
	private readonly IUserInteraction _userInteraction;

	public PlanetsStats(IPlanetsRepository planetsRepository, IPrinter printer, IUserInteraction userInteraction)
	{
		_planetsRepository = planetsRepository;
		_printer = printer;
		_userInteraction = userInteraction;
	}

	public async Task Start()
	{
		IReadOnlyList<Planet>? planets = await _planetsRepository.GetStats();
		
		if (planets is null)
		{
			Console.WriteLine("Failed to load planets stats");
		}
		else
		{
			_printer.PrintPlanetsStats(planets);
			_userInteraction.HandleUserInput(planets);
		}
		
		Close();
	}

	public void Close()
	{
		Console.WriteLine("Press any key to close.");
	}
}