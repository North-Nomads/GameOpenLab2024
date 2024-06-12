using UnityEngine;

namespace GOL.Landscape.Flowers.Genetics
{
	public class SimpleSyntesisGene : ScriptableObject, ISyntesisGene
	{
        [SerializeField] private string description;
        [SerializeReference] private object syntesisTarget;

        public object SyntesisTarget => throw new System.NotImplementedException();

        public string Name => name;

        public string Description => description;

        public void OnApply(IFlower target)
        {
            // TODO
        }

        public void OnFlowerPlant(IFlower target, IFlowerPot pot, float effeciency)
        {
            // TODO
        }

        public void OnFlowerRemove(IFlower target, IFlowerPot pot, float effeciency)
        {
            // TODO
        }

        public void Tick()
        {
            // TODO: somehow produce the resource.
        }
    }
}