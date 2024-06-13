using UnityEngine;

namespace GOL.Landscape.Flowers.Genetics
{
    public class SimpleAntidoteGene : ScriptableObject, IAntidoteGene
    {
        [SerializeField] private float clearEffeciency;
        [SerializeField] private string description;

        public float ClearEfficiency => clearEffeciency;

        public string Name => name;

        public string Description => description;

        public void OnApply(IFlower target)
        {
            // Do nothing.
        }

        public void OnFlowerPlant(IFlower target, IFlowerPot pot, float effeciency)
        {
            pot.RelatedTile.PollutionLevel -= (int)(ClearEfficiency * effeciency);
        }

        public void OnFlowerRemove(IFlower target, IFlowerPot pot, float effeciency)
        {
            pot.RelatedTile.PollutionLevel += (int)(ClearEfficiency * effeciency);
        }
    }
}