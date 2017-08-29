using UnityEngine;

namespace Lounge.Preload
{
    public class App : MonoBehaviour
    {
        private void Start()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
    }
}

