using NorthNomads.GOL.Landscape.Tiles;
using TreeEditor;
using UnityEngine;

namespace NorthNomads.GOL.Landscape.Generation
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
            Debug.Log(options.NoiseScale);
            for (int x = -options.TargetWidth / 2; x < options.TargetWidth / 2; x++)
            {
                for (int y = -options.TargetHeight / 2; y < options.TargetHeight / 2; y++)
                {
                    float soilNoise = Mathf.PerlinNoise(x * options.NoiseScale / options.TargetWidth, y * options.NoiseScale / options.TargetHeight);
                    Debug.Log($"{{{x},{y}}} SoilNoise: {soilNoise}");
                    SoilType soilType = soilTypes[(int)(soilNoise * soilTypes.Length)];
                    float pollutionNoise = Mathf.PerlinNoise((x + options.TargetWidth * 10) * options.NoiseScale / options.TargetWidth, (y + options.TargetHeight * 10) * options.NoiseScale / options.TargetHeight);
                    Debug.Log($"{{{x},{y}}} PollutionNoise: {pollutionNoise}");

                    float lockNoise = Mathf.PerlinNoise((x + options.TargetWidth * 5) * -options.NoiseScale / options.TargetWidth, (y + options.TargetHeight * 5) * -options.NoiseScale / options.TargetHeight);
                    Debug.Log($"{{{x},{y}}} LockNoise: {lockNoise}");

                    result[x, y] = new TileInfo(soilType, (int)(pollutionNoise * options.DifficultyMultiplier), (int)(lockNoise * options.DifficultyMultiplier));
                }
            }
            return result;
        }
    }
}