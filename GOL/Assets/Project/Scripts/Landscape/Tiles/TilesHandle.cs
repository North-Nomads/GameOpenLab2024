using GOL.Landscape.Generation;
using System.Collections.Generic;
using UnityEngine;

namespace GOL.Landscape.Tiles
{
    public class TilesHandle : MonoBehaviour, ITileWorldHandle
    {
        public List<Tile> Tiles { get; } = new();

        IReadOnlyCollection<Tile> ITileWorldHandle.Tiles => Tiles;

        public void Destroy()
        {
            Destroy(gameObject);
        }

        public void DestroyImmediate()
        {
            DestroyImmediate(gameObject);
        }
    }
}