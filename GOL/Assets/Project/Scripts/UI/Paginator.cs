using GOL.Assets.Project.Scripts.UI.Shuttle;
using UnityEngine;

namespace GOL.Assets.Project.Scripts.UI
{
    public class Paginator : MonoBehaviour
    {
        [SerializeField] private Page[] pages;

        private IPage[] Pages => pages;
        private IPage _firstPage;

        private void Awake()
        {
            _firstPage = pages[0];
        }

        private void OnEnable()
        {
            //OpenPage(_firstPage);
        }

        public void OpenPage(IPage page)
        {
            foreach (var nextPage in Pages)
            {
                nextPage.HandleClose();
                if (nextPage == page)
                    page.HandleOpen();
            }
        }
    }
}
