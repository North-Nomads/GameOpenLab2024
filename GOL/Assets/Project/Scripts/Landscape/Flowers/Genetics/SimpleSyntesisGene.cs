using GOL.PlayerScripts;
using GOL.Resources;
using UnityEngine;

namespace GOL.Landscape.Flowers.Genetics
{
    public class SimpleSyntesisGene : ScriptableObject, ISyntesisGene
	{
        [SerializeField] private string description;
        [SerializeReference] private IResource syntesisTarget;
        [SerializeField] private int productionAmount;

        public IResource SyntesisTarget => syntesisTarget;

        public string Name => name;

        public string Description => description;

        public void OnApply(IFlower target)
        {
            // TODO
        }

        public void OnFlowerPlant(IFlower target, IFlowerPot pot, float effeciency)
        {
            if (!syntesisTarget.IsProductionTileRelated)
            {
                SyntesisTarget.ResourceProductionRate += productionAmount;
            }
        }

        public void OnFlowerRemove(IFlower target, IFlowerPot pot, float effeciency)
        {
            SyntesisTarget.ResourceProductionRate -= productionAmount;
        }

        public void OnPlayerEnter(PlayerInventory player)
        {
            if (syntesisTarget.IsProductionTileRelated)
            {
                SyntesisTarget.ResourceProductionRate += productionAmount;
            }
        }

        public void OnPlayerLeave(PlayerInventory player)
        {
            if (syntesisTarget.IsProductionTileRelated)
            {
                SyntesisTarget.ResourceProductionRate -= productionAmount;
            }
        }
    }
}