using NorthNomads.GOL.Landscape.Generation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] private WorldBuilder builder;

    // Start is called before the first frame update
    void Start()
    {
        var generator = new WorldGenerator();
        var options = new GeneratorOptions()
        {
            DifficultyMultiplier = 5,
            NoiseScale = 16,
            Seed = 123123,
            TargetHeight = 64,
            TargetWidth = 64
        };
        var map = generator.GenerateLandscape(options);
        builder.InstantiateWorld(map);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
