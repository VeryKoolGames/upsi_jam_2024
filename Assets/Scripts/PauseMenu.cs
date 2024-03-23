using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool IsGamePaused = false;
    public Canvas pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsGamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.enabled = false;
        Time.timeScale = 1f;
        IsGamePaused = false;
        InputManager.Instance.inputEnabled = true;
    }

    void Pause()
    {
        pauseMenuUI.enabled = true;
        Time.timeScale = 0f;
        IsGamePaused = true;
        InputManager.Instance.inputEnabled = false;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
