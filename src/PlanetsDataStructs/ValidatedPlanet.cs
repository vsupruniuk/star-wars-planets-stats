using System.Text.Json.Serialization;

namespace star_wars_planet_stats.PlanetsDataStructs;

public record ValidatedPlanet(
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("diameter")]
	int Diameter,
	[property: JsonPropertyName("surface_water")]
	int? SurfaceWater,
	[property: JsonPropertyName("population")]
	long? Population
);