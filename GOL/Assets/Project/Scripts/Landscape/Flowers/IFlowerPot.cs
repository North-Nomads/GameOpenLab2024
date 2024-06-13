using GOL.Landscape.Tiles;

namespace GOL.Landscape.Flowers
{
	/// <summary>
	/// Represents the slot for storing placeable items.
	/// </summary>
	public interface IFlowerPot : INotifyPlayerEnter
	{
		/// <summary>
		/// Placed item.
		/// </summary>
		IPlaceableObject Slot { get; }

		/// <summary>
		/// Tile on which the pot is placed.
		/// </summary>
		ITile RelatedTile { get; }

		/// <summary>
		/// Initializes the pot with the given tile instance.
		/// </summary>
		/// <param name="targetTile">The tile to setup the pot.</param>
		void Initialize(Tile targetTile);

		/// <summary>
		/// Plants the item into the pot.
		/// </summary>
		/// <param name="item">An item to plant.</param>
		void Plant(IPlaceableObject item);

		/// <summary>
		/// Removes an item from the pot.
		/// </summary>
		void Remove();
	}
}