using System.Text.Json;
using star_wars_planet_stats.Interfaces;
using star_wars_planet_stats.PlanetsDataStructs;

namespace star_wars_planet_stats.Repositories;

public class PlanetsRepository : IPlanetsRepository
{
	private const string BaseAddress = "https://swapi.dev/api/";
	private const string UriAddress = "planets/";

	private readonly IPlanetValidator _planetValidator;
	private readonly HttpClient _client;

	public PlanetsRepository(HttpClient client, IPlanetValidator planetValidator)
	{
		_client = client;
		_planetValidator = planetValidator;
	}

	public async Task<IReadOnlyList<ValidatedPlanet>?> GetStats()
	{
		_client.BaseAddress = new Uri(BaseAddress);

		HttpResponseMessage response = await _client.GetAsync(UriAddress);

		// TODO handle HttpRequestException 
		response.EnsureSuccessStatusCode();

		string jsonData = await response.Content.ReadAsStringAsync();

		return _planetValidator.ValidatedPlanets(JsonSerializer.Deserialize<StatsResult>(jsonData)!);
	}
}