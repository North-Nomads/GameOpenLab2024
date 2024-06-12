using GOL.Landscape.Tiles;
using System.Collections.Generic;

namespace GOL.Landscape.Generation
{
    /// <summary>
    /// Represents a service for the world instantiation purposes.
    /// </summary>
    public interface ITileWorldHandle
    {
        IReadOnlyCollection<Tile> Tiles { get; }

        void Destroy();

        void DestroyImmediate();
    }
}