using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class waitForIntro : MonoBehaviour
{

   
    

    void Start()
    {
        StartCoroutine(waitForIntroToEnd());    
    }

    IEnumerator waitForIntroToEnd()
    {
        yield return new WaitForSeconds(13);
        Loader.Load(Loader.Scene.Main_Menu);
    }
}
