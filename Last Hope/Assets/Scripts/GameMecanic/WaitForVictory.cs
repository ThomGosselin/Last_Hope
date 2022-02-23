using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForVictory : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(waitForVideoToEnd());
    }

    IEnumerator waitForVideoToEnd()
    {
        yield return new WaitForSeconds(21);
        Loader.Load(Loader.Scene.Credits);
    }
}
