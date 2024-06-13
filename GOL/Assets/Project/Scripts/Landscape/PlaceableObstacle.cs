using GOL.Landscape.Flowers;
using System;
using UnityEngine;

namespace GOL.Landscape
{
    [CreateAssetMenu(fileName = "New Obstacle", menuName = "Placeables/Obstacle")]
    public class PlaceableObstacle : ScriptableObject, IPlaceableObject
	{
        // HACK: this is something very strange, but I need static instance instead of null.
        private static readonly Lazy<PlaceableObstacle> instance = new(() => 
        {
            var result = CreateInstance<PlaceableObstacle>();
            result.prefab = new GameObject("Empty object (DO NOT DELETE)")
            {
                hideFlags = HideFlags.HideInHierarchy
            };
            result.prefab.SetActive(false);
            return result;
        });

        [SerializeField] private GameObject prefab;

        public static PlaceableObstacle EmptyPlaceable => instance.Value;

        public GameObject PlacePrefab => prefab;

        public void OnPlace(IFlowerPot pot)
        {
            // Do nothing.
        }

        public void OnRemove(IFlowerPot pot) 
        { 
            // Do nothing.
        }

        public void Tick()
        {
            // Do nothing.
        }
    }
}