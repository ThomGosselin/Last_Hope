using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class waitForCinematique1 : MonoBehaviour
{




    void Start()
    {
        StartCoroutine(waitForVideoToEnd());
    }

    IEnumerator waitForVideoToEnd()
    {
        yield return new WaitForSeconds(89);
        Loader.Load(Loader.Scene.Game_Level1);
    }
}
