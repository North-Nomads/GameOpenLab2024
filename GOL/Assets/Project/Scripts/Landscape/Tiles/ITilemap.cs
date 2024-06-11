using System.Collections.Generic;

namespace NorthNomads.GOL.Landscape.Tiles
{
	/// <summary>
	/// Represents the interface for the game world map.
	/// </summary>
	public interface ITilemap : IEnumerable<ITile>
	{
		/// <summary>
		/// Gets the width of the map.
		/// </summary>
		int Width { get; }

		/// <summary>
		/// Gets the height of the map.
		/// </summary>
		int Height { get; }

        /// <summary>
        /// Provides the access to the specified tile on the map.
        /// </summary>
        /// <remarks>
        /// The tilemap uses center anchor so the {<see langword="0"/>; <see langword="0"/>} coordinate will access the middle tile.
        /// </remarks>
        /// <param name="x">The <see langword="X"/>-coordinate of the tile.</param>
        /// <param name="y">The <see langword="Y"/>-coordinate of the tile.</param>
        /// <returns>The tile for the specified position.</returns>
        ITile this[int x, int y] { get; }
	}
}