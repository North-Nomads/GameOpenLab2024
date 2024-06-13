using GOL.PlayerScripts;
using UnityEngine;

namespace GOL.Landscape.Flowers
{
    /// <summary>
    /// Represents the placeable item such as flower or obstacle.
    /// </summary>
    public interface IPlaceableObject : INotifyPlayerEnter
	{
        /// <summary>
        /// An object to instantiate on place.
        /// </summary>
		public GameObject PlacePrefab { get; }

        /// <summary>
        /// Handles the item placement.
        /// </summary>
        /// <param name="pot"></param>
		void OnPlace(IFlowerPot pot);

        /// <summary>
        /// Handles the item removal.
        /// </summary>
        /// <param name="pot"></param>
		void OnRemove(IFlowerPot pot);
    }
}