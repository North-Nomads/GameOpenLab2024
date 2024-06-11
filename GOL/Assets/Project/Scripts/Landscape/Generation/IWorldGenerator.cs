using NorthNomads.GOL.Landscape.Tiles;

namespace NorthNomads.GOL.Landscape.Generation
{
    /// <summary>
    /// Represents a service for the world generation purposes.
    /// </summary>
    public interface IWorldGenerator
    {
        /// <summary>
        /// Generates the tilemap with the specified generation options.
        /// </summary>
        /// <param name="options">The options for the generation process.</param>
        /// <returns>The landscape tilemap for the generation.</returns>
        ITilemap GenerateLandscape(GeneratorOptions options);
    }
}