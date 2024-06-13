using UnityEngine;

namespace GOL.Assets.Project.Scripts.UI
{
    public class Paginator : MonoBehaviour
    {
        [SerializeField] private IPage[] pages;
        private IPage _firstPage;

        private void OnEnable()
        {
            OpenPage(_firstPage);
        }

        public void OpenPage(IPage page)
        {
            foreach (var nextPage in pages)
            {
                page.HandleClose();
                if (nextPage == page)
                    page.HandleOpen();
            }
        }
    }
}
