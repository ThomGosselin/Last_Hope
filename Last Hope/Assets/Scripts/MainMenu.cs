using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Loader.Load(Loader.Scene.LvlChoice);
    }

    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
