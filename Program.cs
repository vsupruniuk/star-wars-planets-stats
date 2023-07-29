using star_wars_planet_stats.Classes;
using star_wars_planet_stats.Repositories;

PlanetsStats planetsStats = new PlanetsStats(
	new PlanetsRepository(
		new HttpClient(),
		new PlanetValidator()
	),
	new Printer(),
	new ConsoleUserInteraction(
		new StatsHandler()
	)
);

try
{
	await planetsStats.Start();
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
	Console.WriteLine("An unexpected error has occurred. Please, press any key to close");
}

Console.ReadKey();