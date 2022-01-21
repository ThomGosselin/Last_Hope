using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wait : MonoBehaviour
{
    

    void Start()
    {
        StartCoroutine(waitForIntro());    
    }

    IEnumerator waitForIntro()
    {
        yield return new WaitForSeconds(5);
        Loader.Load(Loader.Scene.Main_Menu);
    }
}
