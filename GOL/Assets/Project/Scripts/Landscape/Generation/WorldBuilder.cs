using NorthNomads.GOL.Landscape.Tiles;
using UnityEngine;

namespace NorthNomads.GOL.Landscape.Generation
{
    public class WorldBuilder : MonoBehaviour, IWorldBuilder
    {
        [SerializeField] private Tile[] tilePrefabs;

        public void InstantiateWorld(ITilemap map)
        {
            for (int x = -map.Width / 2; x < map.Width / 2; x++)
            {
                for (int y = -map.Height / 2; y < map.Height / 2; y++)
                {
                    var info = map[x, y];
                    var prefab = tilePrefabs[(int)info.SoilType];
                    var tile = Instantiate(prefab, new Vector3(x, 0, y), Quaternion.identity);
                    tile.ApplyInfo((TileInfo)info);
                }
            }
        }
    }
}