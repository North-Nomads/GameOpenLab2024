using GOL.Resources;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace GOL.PlayerScripts
{
    public class PlayerInventory : MonoBehaviour
    {
        [SerializeField] private List<(IResource resource, float amount)> _resources;

        public IEnumerable<(IResource resource, float amount)> Resources => _resources;

        private void Update()
        {
            for (int i = 0; i < _resources.Count; i++)
            {
                var resource = _resources[i];
                resource.amount += resource.resource.ResourceProductionRate * Time.deltaTime;
                _resources[i] = resource;
            }
        }

        public bool TryConsumeResource(IResource consumedResource, float amount)
        {
            var res = _resources.FirstOrDefault(x => x.resource.GetType() == consumedResource.GetType());
            if (res.amount < amount)
                return false;

            res.amount -= amount;
            return true;
        }
    }
}