using UnityEngine;

namespace GOL.Assets.Project.Scripts.UI.Shuttle
{
    public abstract class Page : MonoBehaviour, IPage
    {
        public abstract void HandleClose();

        public abstract void HandleOpen();
    }
}
