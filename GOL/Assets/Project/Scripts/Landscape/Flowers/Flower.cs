using GOL.Landscape.Flowers.Genetics;
using System.Collections.Generic;
using UnityEngine;

namespace GOL.Landscape.Flowers
{
    [CreateAssetMenu(fileName = "New Flower Definition", menuName = "Placeables/Flower")]
    public class Flower : ScriptableObject, IFlower
    {
        [SerializeField] private List<IGene> genes = new();
        [SerializeField] private string description;
        [SerializeField] private ISoilGene soilGene;
        [SerializeField] private GameObject prefab;

        public IReadOnlyCollection<IGene> Genes => genes;

        public string Name => name;

        public string Description => description;

        public GameObject PlacePrefab => prefab;

        public ISoilGene SoilGene => soilGene;

        public void AddGene(IGene gene)
        {
            if (gene is ISoilGene soil)
            {
                if (soilGene == null)
                {
                    soilGene = soil;
                }
                else
                {
                    ThrowHelper.ThrowArgumentException("Can't add more than on soil gene.");
                }
            }
            genes.Add(gene);
        }

        public bool CanPlant(SoilType soil)
        {
            return soilGene.TargetSoilType == soil;
        }

        public float GetPlantCoefficient(SoilType soil)
        {
            return CanPlant(soil) ? 1 : 0;
        }

        public void OnPlace(IFlowerPot pot)
        {
            float effeciency = GetPlantCoefficient(pot.RelatedTile.SoilType);
            foreach (var gene in Genes)
            {
                gene.OnFlowerPlace(effeciency);
            }
        }

        public void RemoveGene(IGene gene)
        {
            if (gene == soilGene)
            {
                soilGene = null;
            }
            genes.Remove(gene);
        }
    }
}