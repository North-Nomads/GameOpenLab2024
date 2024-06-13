using UnityEngine;
using UnityEngine.SceneManagement;

namespace GOL.Assets.Project.Scripts.UI
{
    public class PlayButton : MonoBehaviour, IButton
    {
        private const int GameScene = 1;

        public void ExecuteOnClick()
        {
            SceneManager.LoadScene(GameScene);
        }

        public void OnCursorEntered()
        {
            throw new System.NotImplementedException();
        }

        public void OnCursorLeave()
        {
            throw new System.NotImplementedException();
        }
    }
}