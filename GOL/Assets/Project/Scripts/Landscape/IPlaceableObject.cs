using UnityEngine;

namespace GOL.Landscape.Flowers
{
    public interface IPlaceableObject : ITickable
	{
		public GameObject PlacePrefab { get; }

		void OnPlace(IFlowerPot pot);

		void OnRemove(IFlowerPot pot);
	}
}