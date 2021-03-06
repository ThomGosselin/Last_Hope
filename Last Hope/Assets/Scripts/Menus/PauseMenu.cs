using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUi;
    public GameObject Player;
    public GameObject Background;

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
        pauseMenuUi.SetActive(false);
        GameIsPaused = false;
        Player.SetActive(true);
        Background.SetActive(false);
        ClosePause();
    }

    void Pause()
    {
        pauseMenuUi.SetActive(true);
        GameIsPaused = true;
        Player.SetActive(false);
        Background.SetActive(true);
    }

 
    public void CommandMenu()
    {

    }

    public void LoadMenu()
    {
        Loader.Load(Loader.Scene.Main_Menu);
        GameIsPaused = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void ClosePause()
    {
        FindObjectOfType<AudioManager>().Pause("Pause");
    }
}
