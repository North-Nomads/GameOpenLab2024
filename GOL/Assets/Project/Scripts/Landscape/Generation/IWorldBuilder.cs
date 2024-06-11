using NorthNomads.GOL.Landscape.Tiles;

namespace NorthNomads.GOL.Landscape.Generation
{
    /// <summary>
    /// Represents a service for the world instantiation purposes.
    /// </summary>
    public interface IWorldBuilder
    {
        /// <summary>
        /// Instantiates the world by specified world map info.
        /// </summary>
        /// <param name="map">The map to build tiles for.</param>
        void InstantiateWorld(ITilemap map);
    }
}