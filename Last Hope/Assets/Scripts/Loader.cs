using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader
{
    public enum Scene
    {
        Intro,
        Loading,
        LvlChoice,
        Game_Level1,
        Main_Menu,
    }

    private static Action onLoaderCallback;

    public static void Load(Scene scene)
    {
        //demander au loader de charger la prochaine scene
        onLoaderCallback = () =>
        {
            SceneManager.LoadScene(scene.ToString());
        };
        //chargement du loading screen
        SceneManager.LoadScene(Scene.Loading.ToString());
    }



    public static void LoaderCallback()
    {
        // fonction executer apres le 1er update
        //execute le chargement de la scene
        if (onLoaderCallback != null)
        {
            onLoaderCallback();
            onLoaderCallback = null;
        }
    }
}
