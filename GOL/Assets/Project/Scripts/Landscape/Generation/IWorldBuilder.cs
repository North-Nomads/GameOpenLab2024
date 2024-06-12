using GOL.Landscape.Tiles;

namespace GOL.Landscape.Generation
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
        /// <param name="tileScale">The scale of the tile to set gaps between tiles.</param>
        ITileWorldHandle InstantiateWorld(ITilemap map, float tileScale = 1);
    }
}