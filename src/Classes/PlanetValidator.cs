using star_wars_planet_stats.DTOs;
using star_wars_planet_stats.Interfaces;
using star_wars_planet_stats.Types;

namespace star_wars_planet_stats.Classes;

public class PlanetValidator : IPlanetValidator
{
	public IReadOnlyList<Planet>? ValidatedPlanets(StatsResultDTO? statsResult)
	{
		if (statsResult is null)
		{
			return null;
		}
		else
		{
			List<Planet> validatedPlanets = new List<Planet>();

			foreach (PlanetDTO planet in statsResult.Results)
			{
				validatedPlanets.Add(new Planet(
					planet.Name,
					int.Parse(planet.Diameter),
					int.TryParse(planet.SurfaceWater, out int parsedInt) ? parsedInt : null,
					long.TryParse(planet.Population, out long parsedLong) ? parsedLong : null
				));
			}

			return validatedPlanets.AsReadOnly();
		}
	}
}