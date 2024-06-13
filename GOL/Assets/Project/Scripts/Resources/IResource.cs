using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IResource
{
    public float ResourceProductionRate { get; }

    public string ResourceName { get; }
    public string ResourceDescription { get; }


}
