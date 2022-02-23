using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader
{
    private class LoadingMonoBehaviour: MonoBehaviour { }

    public enum Scene
    {
        Intro,
        Loading,
        LvlChoice,
        Game_Level1,
        Main_Menu,
        TempSceneAfterLevel1,
        CinematiqueLVL1,
        Game_Level2,
        CinematiqueLVL1To2,
        CinemativeLvl2To3,
        Game_Level3,
        CinematiqueVictoire,
        GameOver,
        GameOverMenu,
        Credits,
    }

    private static Action onLoaderCallback;
    private static AsyncOperation loadingAsyncOperation;

    public static void Load(Scene scene)
    {
        //demander au loader de charger la prochaine scene
        onLoaderCallback = () =>
        {
            GameObject loadingGameObject = new GameObject("Loading Game Object");
            loadingGameObject.AddComponent<LoadingMonoBehaviour>().StartCoroutine(LoadSceneAsync(scene));
        };
        //chargement du loading screen
        SceneManager.LoadSceneAsync(Scene.Loading.ToString());
    }

    private static IEnumerator LoadSceneAsync(Scene scene)
    {
        yield return null;
        loadingAsyncOperation = SceneManager.LoadSceneAsync(scene.ToString());

        while (!loadingAsyncOperation.isDone)
        {
            yield return null;
        }
    }

    public static float GetLoadingProgress()
    {
        if (loadingAsyncOperation != null)
        {
            return loadingAsyncOperation.progress;
        }
        else
        {
            return 1f;
        }
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
