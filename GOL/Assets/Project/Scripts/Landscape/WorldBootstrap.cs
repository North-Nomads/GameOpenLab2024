using GOL.Landscape.Generation;
using UnityEngine;

namespace GOL.Landscape
{
    public class WorldBootstrap : MonoBehaviour
    {
        [SerializeField] private WorldBuilder builder;

        [Header("Generation options")]
        [SerializeField] [Range(0, 100)] private float difficultyMultiplier;
        [SerializeField] [Range(0.001f, 1000)] private float noiseScale;
        [SerializeField] private int seed;
        [SerializeField] private Vector2Int mapSize;
        [SerializeField] private PlaceableObstacle[] obstacles;

        [Header("Build options")]
        [SerializeField] private float buildWorldSize;

        private ITileWorldHandle _tileWorld;

        private void MakeWorld()
        {
            var generator = new WorldGenerator();
            var options = new GeneratorOptions()
            {
                DifficultyMultiplier = difficultyMultiplier,
                NoiseScale = noiseScale,
                Seed = seed,
                TargetHeight = mapSize.x,
                TargetWidth = mapSize.y,
                Obstacles = obstacles,
            };
            var map = generator.GenerateLandscape(options);
            _tileWorld = builder.InstantiateWorld(map, buildWorldSize);
            (_tileWorld as MonoBehaviour).transform.parent = transform;
        }

        internal void DestroyWorld()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                DestroyImmediate(transform.GetChild(i).gameObject);
            }
        }

        public void ResetWorld(bool immediate)
        {
            DestroyWorld();
            MakeWorld();
        }
    }
}