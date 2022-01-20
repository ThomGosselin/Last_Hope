using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUi;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
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
        Debug.Log("Resume");
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        Debug.Log("pause");
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadOptions()
    {
        Debug.Log("Je suis un beau menu options");
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        Debug.Log("Retour au menu principale");
    }

    public void QuitGame()
    {
        Debug.Log("Auto destruction dans 5.. 4.. 3.. 2.. 1.. fuck jai pas exploser");
        Application.Quit();
    }
}
