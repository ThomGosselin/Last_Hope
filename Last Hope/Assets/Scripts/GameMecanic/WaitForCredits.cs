using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForCredits : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(waitForVideoToEnd());
    }

    IEnumerator waitForVideoToEnd()
    {
        yield return new WaitForSeconds(38);
        Loader.Load(Loader.Scene.Main_Menux);
    }
}
