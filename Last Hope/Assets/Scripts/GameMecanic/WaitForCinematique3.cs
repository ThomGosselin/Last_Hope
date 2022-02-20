using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForCinematique3 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(waitForVideoToEnd());
    }

    IEnumerator waitForVideoToEnd()
    {
        yield return new WaitForSeconds(12);
        Loader.Load(Loader.Scene.Game_Level3);
    }
}
