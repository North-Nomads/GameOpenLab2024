using UnityEngine;

namespace GOL.Resources
{
    [CreateAssetMenu(fileName = "New Resource Definition", menuName = "Resources/Resource Definition")]
    public class InventoryResource : ScriptableObject, IResource
    {
        [SerializeField] private float resourceProductionRate = -5;
        [SerializeField] private string description;
        [SerializeField] private bool tileRelatedProduction;
        [SerializeField] private bool isStabilityRelated;

        public float ResourceProductionRate
        {
            get => resourceProductionRate;
            set => resourceProductionRate = value;
        }

        public string ResourceName => name;

        public string ResourceDescription => description;

        public bool IsProductionTileRelated => tileRelatedProduction;

        public bool IsStabilityRelated => isStabilityRelated;
    }
}