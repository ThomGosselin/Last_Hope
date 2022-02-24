using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForGameVver : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(waitForVideoToEnd());
    }

    IEnumerator waitForVideoToEnd()
    {
        yield return new WaitForSeconds(21);
        Loader.Load(Loader.Scene.Main_Menu);
    }
}
