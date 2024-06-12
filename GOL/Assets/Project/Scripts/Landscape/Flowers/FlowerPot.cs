using UnityEngine;

namespace GOL.Landscape.Flowers
{
	public class FlowerPot : MonoBehaviour
	{
		[SerializeField] private IFlowerPot pot;

		public IFlowerPot Info => pot;

		private GameObject _item;

		public void ApplyInfo(IFlowerPot info)
		{
			pot = info;
			AddItem(pot.Slot);
		}

		public void RemoveItem()
		{
			if (_item != null)
				Destroy(_item);
		}

		public void AddItem(IPlaceableObject item)
		{
            _item = Instantiate(item.PlacePrefab, transform);
            item.OnPlace(pot);
        }
	}
}