using System.Collections;
using System.Collections.Generic;

namespace GOL.Landscape.Tiles
{
    public class Tilemap : ITilemap
    {
        private readonly ITile[,] tiles;

        public Tilemap(int width, int height)
        {
            Width = width;
            Height = height;
            tiles = new ITile[width, height];
        }

        public ITile this[int x, int y]
        {
            get
            {
                x += Width / 2;
                y += Height / 2;
                return tiles[x, y];
            }
            set
            {
                x += Width / 2;
                y += Height / 2;
                tiles[x, y] = value;
            }
        }

        public int Width { get; }

        public int Height { get; }

        public IEnumerator<ITile> GetEnumerator()
        {
            foreach (ITile tile in tiles)
            {
                yield return tile;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return tiles.GetEnumerator();
        }
    }
}