using star_wars_planet_stats.Interfaces;
using star_wars_planet_stats.PlanetsDataStructs;

namespace star_wars_planet_stats.Classes;

public class PlanetsStats : IPlanetsStats
{
	private readonly IPlanetsRepository _planetsRepository;
	private readonly IPrinter _printer;
	private readonly IStatsHandler _statsHandler;

	public PlanetsStats(IPlanetsRepository planetsRepository, IPrinter printer, IStatsHandler statsHandler)
	{
		_planetsRepository = planetsRepository;
		_printer = printer;
		_statsHandler = statsHandler;
	}

	public async Task Start()
	{
		IReadOnlyList<ValidatedPlanet>? planets = await _planetsRepository.GetStats();
		
		if (planets is null)
		{
			Console.WriteLine("Failed to load planets stats");
		}
		else
		{
			_printer.PrintPlanetsStats(planets);
			_statsHandler.HandleUserInput(planets);
		}
		
		Close();
	}

	public void Close()
	{
		Console.WriteLine("Press any key to close.");
	}
}