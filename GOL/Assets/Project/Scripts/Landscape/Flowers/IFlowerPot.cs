using GOL.Landscape.Tiles;

namespace GOL.Landscape.Flowers
{
	public interface IFlowerPot : ITickable
	{
		IPlaceableObject Slot { get; }

		ITile RelatedTile { get; }

		void Initialize(Tile targetTile);

		void Plant(IPlaceableObject item);

		void Remove();
	}
}