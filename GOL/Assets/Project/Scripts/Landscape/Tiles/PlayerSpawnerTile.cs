using UnityEngine;

namespace GOL.Landscape.Tiles
{
	public class PlayerSpawnerTile : Tile
	{
		[SerializeField] private GameObject playerPrefab;
        [SerializeField] private Transform spawnAnchor;

        private void Start()
        {
            Instantiate(playerPrefab, spawnAnchor.position, Quaternion.identity);
        }
    }
}