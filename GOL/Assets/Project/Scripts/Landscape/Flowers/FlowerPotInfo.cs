using GOL.Landscape.Tiles;
using GOL.PlayerScripts;

namespace GOL.Landscape.Flowers
{
    public class FlowerPotInfo : IFlowerPot
	{
		public FlowerPotInfo()
		{
		}

        public IPlaceableObject Slot { get; set; } = PlaceableObstacle.EmptyPlaceable;

        public FlowerPot RelatedPot { get; set; }

        public ITile RelatedTile { get; set; }

        public void Plant(IPlaceableObject item)
        {
            Slot = item;
            if (RelatedPot != null)
            {
                RelatedPot.RemoveItem();
                RelatedPot.AddItem(item);
            }
        }

        public void Initialize(Tile tile)
        {
            RelatedTile = tile.Info;
            for (int i = 0; i < tile.Info.Pots.Count; i++)
            {
                if (this == tile.Info.Pots[i])
                {
                    RelatedPot = tile.Pots[i];
                    return;
                }
            }
        }

        public void Remove()
        {
            RelatedPot.RemoveItem();
        }

        public void OnPlayerEnter(PlayerInventory player)
        {
            Slot.OnPlayerEnter(player);
        }

        public void OnPlayerLeave(PlayerInventory player)
        {
            Slot.OnPlayerLeave(player);
        }
    }
}