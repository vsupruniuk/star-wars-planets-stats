using System.Text.Json.Serialization;

namespace star_wars_planet_stats.PlanetsDataStructs;

public record StatsResult(
	[property: JsonPropertyName("count")] int Count,
	[property: JsonPropertyName("next")] string Next,
	[property: JsonPropertyName("previous")]
	object? Previous,
	[property: JsonPropertyName("results")]
	IReadOnlyList<Planet> Results
);