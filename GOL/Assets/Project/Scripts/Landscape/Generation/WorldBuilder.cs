using GOL.Landscape.Tiles;
using UnityEngine;

namespace GOL.Landscape.Generation
{
    public class WorldBuilder : MonoBehaviour, IWorldBuilder
    {
        [SerializeField] private Tile[] tilePrefabs;
        [SerializeField] private PlayerSpawnerTile startTile;
        [SerializeField] private PlayerFinishTile finishTile;

        public ITileWorldHandle InstantiateWorld(ITilemap map, float tileScale = 1f)
        {
            var world = new GameObject("Tiles handle").AddComponent<TilesHandle>();
            for (int x = -map.Width / 2; x < map.Width / 2; x++)
            {
                for (int y = -map.Height / 2; y < map.Height / 2; y++)
                {
                    var info = map[x, y];
                    Tile prefab;
                    if (info.TileState == TileState.Start)
                    {
                        prefab = startTile;
                    }
                    else if (info.TileState == TileState.Finish)
                    {
                        prefab = finishTile;
                    }
                    else
                    {
                        prefab = tilePrefabs[(int)info.SoilType];
                    }
                    var tile = Instantiate(prefab, new Vector3(x * tileScale, 0, y * tileScale), Quaternion.identity);
                    tile.ApplyInfo((TileInfo)info);
                    tile.transform.parent = world.transform;
                    world.Tiles.Add(tile);
                }
            }
            return world;
        }
    }
}