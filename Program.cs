using star_wars_planet_stats.Classes;
using star_wars_planet_stats.Repositories;

PlanetsStats planetsStats = new PlanetsStats(
	new PlanetsRepository(
		new HttpClient(),
		new PlanetValidator()
	),
	new Printer(),
	new StatsHandler()
);

try
{
	await planetsStats.Start();
}
catch (Exception exception)
{
	Console.WriteLine("An unexpected error has occurred. Please, press any key to close");
}

Console.ReadKey();

