using NorthNomads.GOL.Landscape.Flowers;
using NorthNomads.GOL.Landscape.Flowers.Genetics;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace NorthNomads.GOL.Landscape.Tiles
{
    public class Tile : MonoBehaviour, ITile
    {
        [SerializeField] private SoilType soilType;
        [SerializeField] private FlowerCollection flowers;
        [SerializeField] private int lockLevel;
        [SerializeField] private int pollutionLevel;

        // HACK: Just for test
        [SerializeField] private GameObject lockPrefab;
        [SerializeField] private GameObject pollutionPrefab;

        public bool IsStable => PollutionLevel <= 0;

        public bool IsLocked => LockLevel > 0;

        public SoilType SoilType => soilType;

        public int LockLevel { get => lockLevel; private set => lockLevel = value; }

        public int PollutionLevel { get => pollutionLevel; private set => pollutionLevel = value; }

        public IReadOnlyCollection<IFlower> Flowers => flowers;

        public void ApplyInfo(TileInfo info)
        {
            lockLevel = info.LockLevel;
            pollutionLevel = info.PollutionLevel;
            // HACK
            for (int i = 0; i < lockLevel; i++)
            {
                Instantiate(lockPrefab, transform.position + Vector3.up * i + new Vector3(0.25f, 0, 0.25f), Quaternion.identity);
            }
            for (int i = 0; i < pollutionLevel; i++)
            {
                Instantiate(pollutionPrefab, transform.position + Vector3.up * i - new Vector3(0.25f, 0, 0.25f), Quaternion.identity);
            }
        }

        public void Plant(IFlower flower)
        {
            if (!flower.CanPlant(SoilType))
                ThrowHelper.ThrowArgumentOutOfRangeException("Can't plant the specified flower.");
            flowers.Add(flower);
            float plantCoefficient = flower.GetPlantCoefficient(SoilType);
            foreach (var gene in flower.Genes)
            {
                switch (gene)
                {
                    case IAntidoteGene antidote:
                        PollutionLevel -= (int)(antidote.ClearEfficiency * plantCoefficient);
                        break;
                    // TODO
                }
            }
        }

        public void Remove(IFlower flower)
        {
            flowers.Remove(flower);
            float plantCoefficient = flower.GetPlantCoefficient(SoilType);
            foreach (var gene in flower.Genes)
            {
                switch (gene)
                {
                    case IAntidoteGene antidote:
                        PollutionLevel += (int)(antidote.ClearEfficiency * plantCoefficient);
                        break;
                    // TODO
                }
            }
        }
    }
}