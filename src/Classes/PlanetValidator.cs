using star_wars_planet_stats.Interfaces;
using star_wars_planet_stats.PlanetsDataStructs;

namespace star_wars_planet_stats.Classes;

public class PlanetValidator : IPlanetValidator
{
	public IReadOnlyList<ValidatedPlanet>? ValidatedPlanets(StatsResult? statsResult)
	{
		if (statsResult is null)
		{
			return null;
		}
		else
		{
			List<ValidatedPlanet> validatedPlanets = new List<ValidatedPlanet>();

			foreach (Planet planet in statsResult.Results)
			{
				validatedPlanets.Add(new ValidatedPlanet(
					Name: planet.Name,
					Diameter: int.Parse(planet.Diameter),
					SurfaceWater: planet.SurfaceWater != "unknown" ? int.Parse(planet.SurfaceWater) : null,
					Population: planet.Population != "unknown" ? long.Parse(planet.Population) : null
				));
			}

			return validatedPlanets.AsReadOnly();
		}
	}
}