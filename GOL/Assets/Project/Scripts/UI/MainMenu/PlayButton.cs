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
    }
}