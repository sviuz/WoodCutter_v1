using System;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class StopGameScript : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] private GameObject pauseMenuUI;
    
    [Header("Buttons")]
    [SerializeField] private Button continueButton;
    [SerializeField] private Button menuButton;
    [SerializeField] private Button quitButton;
    private bool _gameIsPaused;


    private void Start()
    {
        _gameIsPaused = false;
        menuButton.onClick.AddListener(LoadMenu);
        quitButton.onClick.AddListener(QuitGame);
        continueButton.onClick.AddListener(Continue);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_gameIsPaused) Continue();
            else Pause();
        }
    }

    private void Continue()
    {
        pauseMenuUI.SetActive(false);//Делаем наше стоп меню неактивным
        Time.timeScale = 1f;//востанавливаем время в игре
        _gameIsPaused = false;
    }

    private void Pause()
    {
        pauseMenuUI.SetActive(true);//Делаем наше стоп меню активным
        Time.timeScale = 0f;//останавливаем время в игре
        _gameIsPaused = true;
    }

    private void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}
