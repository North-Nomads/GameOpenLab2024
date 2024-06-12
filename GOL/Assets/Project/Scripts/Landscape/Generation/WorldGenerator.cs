using GOL.Landscape.Tiles;
using UnityEngine;

namespace GOL.Landscape.Generation
{
    /// <summary>
    /// Represents the default implementation of the world generator.
    /// </summary>
    public class WorldGenerator : IWorldGenerator
    {
        private readonly SoilType[] soilTypes = (SoilType[])System.Enum.GetValues(typeof(SoilType));

        /// <inheritdoc/>
        public ITilemap GenerateLandscape(GeneratorOptions options)
        {
            var result = new Tilemap(options.TargetWidth, options.TargetHeight);
            Vector2 size = new(options.TargetWidth, options.TargetHeight);
            for (int x = -options.TargetWidth / 2; x < options.TargetWidth / 2; x++)
            {
                for (int y = -options.TargetHeight / 2; y < options.TargetHeight / 2; y++)
                {
                    Vector2 position = new(x, y);
                    float soilNoise = RandomSample(position, options);
                    //Debug.Log($"{{{x},{y}}} SoilNoise: {soilNoise}");
                    SoilType soilType = soilTypes[(int)(soilNoise * soilTypes.Length)];
                    float pollutionNoise = RandomSample(position + size * 10, options);
                    //Debug.Log($"{{{x},{y}}} PollutionNoise: {pollutionNoise}");

                    float lockNoise = RandomSample(Matrix4x4.Rotate(Quaternion.Euler(0, 45, 0)) * (position + size * 5), options);
                    //Debug.Log($"{{{x},{y}}} LockNoise: {lockNoise}");

                    var tile = result[x, y] = new TileInfo(soilType, (int)(pollutionNoise * options.DifficultyMultiplier), (int)(lockNoise * options.DifficultyMultiplier));
                    int potsCount = tile.Pots.Count;
                    int placedPotFlags = (int)(pollutionNoise * (1 << potsCount)) ^ (int)(lockNoise * (1 << potsCount));

                    for (int i = 0; i < potsCount; i++)
                    {
                        TryPlaceRandomObstacle(placedPotFlags, i, tile, options);
                    }
                }
            }
            return result;
        }

        private void TryPlaceRandomObstacle(int flags, int index, ITile targetTile, GeneratorOptions options)
        {
            if ((flags & (1 << index)) != 0)
            {
                targetTile.Pots[index].Plant(options.Obstacles[Random.Range(0, options.Obstacles.Length)]);
            }
        }

        private static float RandomSample(Vector2 position, GeneratorOptions options)
        {
            position += options.NoiseScale * Vector2.one / new Vector2(options.TargetWidth, options.TargetHeight);
            position += Vector2.one * options.Seed;
            return Mathf.Clamp01(Mathf.PerlinNoise(position.x, position.y)) - 1e-7f;
        }
    }
}