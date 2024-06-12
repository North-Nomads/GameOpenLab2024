using GOL.Landscape.Flowers;
using System.Collections.Generic;

namespace GOL.Landscape.Tiles
{
    /// <summary>
    /// Represents the base interface for the landscape tiles.
    /// </summary>
    public interface ITile : ITickable
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
        int LockLevel { get; set; }

        /// <summary>
        /// Gets the current pollution level of the tile.
        /// </summary>
        int PollutionLevel { get; set; }

        /// <summary>
        /// Gets all the flower pots placed on the tile.
        /// </summary>
        IReadOnlyList<IFlowerPot> Pots { get; }

        /// <summary>
        /// Plants the flower on the tile. Its effect applies to the tile properties.
        /// </summary>
        /// <param name="flower">The flower to plant.</param>
        /// <param name="pot">The pot to plant to.</param>
        void Plant(IFlower flower, IFlowerPot pot);

        /// <summary>
        /// Removes the flower from the tile. Its effect is removes from the tile properties.
        /// </summary>
        /// <param name="pot">The pot to remove from.</param>
        void RemoveFrom(IFlowerPot pot);
    }
}