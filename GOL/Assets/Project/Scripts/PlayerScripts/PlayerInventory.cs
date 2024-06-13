using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private List<(IResource resource, float amount)> _resources;

    public IEnumerable<(IResource resource, float amount)> Resources { get => _resources; }
    
    private void Start()
    {
        _resources = new()
        {
            new (new OxygenResource(), 1000)
        };
    }

    
    private void Update()
    {
        for(int i = 0; i < _resources.Count; i++)
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
