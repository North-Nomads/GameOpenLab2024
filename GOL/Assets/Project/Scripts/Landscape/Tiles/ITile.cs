using NorthNomads.GOL.Landscape.Flowers;
using System.Collections.Generic;

namespace NorthNomads.GOL.Landscape
{
    /// <summary>
    /// Represents the base interface for the landscape tiles.
    /// </summary>
    public interface ITile
    {
        /// <summary>
        /// Gets a value indicating whether the tile is able to produce oxygen and is stable for the player presence.
        /// </summary>
        bool IsStable { get; }

        /// <summary>
        /// Gets a value indicating whether the tile is locked for the transportation.
        /// </summary>
        bool IsLocked { get; }

        /// <summary>
        /// Gets the soil type for the tile.
        /// </summary>
        SoilType SoilType { get; }

        /// <summary>
        /// Gets the current lock level of the tile.
        /// </summary>
        int LockLevel { get; }

        /// <summary>
        /// Gets the current pollution level of the tile.
        /// </summary>
        int PollutionLevel { get; }

        /// <summary>
        /// Gets all the flowers planted on the tile.
        /// </summary>
        IReadOnlyCollection<IFlower> Flowers { get; }

        /// <summary>
        /// Plants the flower on the tile. Its effect applies to the tile properties.
        /// </summary>
        /// <param name="flower">The flower to plant.</param>
        void Plant(IFlower flower);

        /// <summary>
        /// Removes the flower from the tile. Its effect is removes from the tile properties.
        /// </summary>
        /// <param name="flower">The flower to remove.</param>
        void Remove(IFlower flower);
    }
}