using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GOL.Resources
{
    public interface IResource
    {
        public float ResourceProductionRate { get; set; }

        public string ResourceName { get; }
        public string ResourceDescription { get; }

        public bool IsProductionTileRelated { get; }

        public bool IsStabilityRelated { get; }
    }
}