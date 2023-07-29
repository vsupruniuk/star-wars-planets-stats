namespace star_wars_planet_stats.Types;

public readonly record struct Planet(string Name, int Diameter, int? SurfaceWater, long? Population);