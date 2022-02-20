using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForCinematique2 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(waitForVideoToEnd());
    }

    IEnumerator waitForVideoToEnd()
    {
        yield return new WaitForSeconds(16);
        Loader.Load(Loader.Scene.Game_Level2);
    }
}
