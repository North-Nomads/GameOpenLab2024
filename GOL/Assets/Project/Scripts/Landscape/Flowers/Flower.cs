using GOL.Landscape.Flowers.Genetics;
using GOL.PlayerScripts;
using System.Collections.Generic;
using System.Linq;
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
                gene.OnFlowerPlant(this, pot, effeciency);
            }
        }

        public void OnRemove(IFlowerPot pot)
        {
            float effeciency = GetPlantCoefficient(pot.RelatedTile.SoilType);
            foreach (var gene in Genes)
            {
                gene.OnFlowerRemove(this, pot, effeciency);
            }
        }

        public void OnPlayerEnter(PlayerInventory player)
        {
            foreach (var gene in Genes.OfType<ISyntesisGene>())
            {
                gene.OnPlayerEnter(player);
            }
        }

        public void OnPlayerLeave(PlayerInventory player)
        {
            foreach (var gene in Genes.OfType<ISyntesisGene>())
            {
                gene.OnPlayerLeave(player);
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