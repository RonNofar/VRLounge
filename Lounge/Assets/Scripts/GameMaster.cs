using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Lounge
{
    public class GameMaster : MonoBehaviour
    {
        public void QuitGame()
        {
            Application.Quit();
        }

        public void RestartPreloader()
        {
            SceneManager.LoadScene(0);
        }
    }
}
