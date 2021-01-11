using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace StopGame
{
    public class TryAgainButton : MonoBehaviour
    {
        [SerializeField] private Button tryAgainButton;
        [SerializeField] private Button mainMenuButton;

        private void Awake()
        {
            tryAgainButton.onClick.AddListener(TryAgainScene);
            mainMenuButton.onClick.AddListener(MainMenuScene);
        }

        private void MainMenuScene()
        {
            SceneManager.LoadScene("MainMenu");
        }

        private void TryAgainScene()
        {
            SceneManager.LoadScene("TheGame");
        }
    }
}
