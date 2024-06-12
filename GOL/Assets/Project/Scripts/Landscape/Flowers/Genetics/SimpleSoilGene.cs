using UnityEngine;

namespace GOL.Landscape.Flowers.Genetics
{
    public class SimpleSoilGene : ScriptableObject, ISoilGene
    {
        [SerializeField] private SoilType targetSoilType;
        [SerializeField] private string description;

        public SoilType TargetSoilType => targetSoilType;

        public string Name => name;

        public string Description => description;

        public void OnApply(IFlower target)
        {
            // Do nothing.
        }

        public void OnFlowerPlant(IFlower target, IFlowerPot pot, float effeciency)
        {
            // Also do nothing.
        }

        public void OnFlowerRemove(IFlower target, IFlowerPot pot, float effeciency)
        {
            // Do nothing too.
        }

        public void Tick()
        {
            // Yeah, do nothing.
        }
    }
}