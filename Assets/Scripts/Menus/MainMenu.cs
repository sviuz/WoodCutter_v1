using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Menus
{
    public class MainMenu : MonoBehaviour
    {
        [Header("Buttons")]
        [SerializeField] private Button startButton;

        private void Awake()
        {
            startButton.onClick.AddListener(StartGame);
        }

        private void StartGame()
        {
            SceneManager.LoadScene("TheGame");//запускаем сцену начала игры
        }
    }
}
