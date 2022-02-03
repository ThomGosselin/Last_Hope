using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level1Manager : MonoBehaviour
{
    public bool key1Good;
    public bool key2Good;
    public bool key3Good;


    public void Update()
    {
        if(key1Good && key2Good && key3Good)
        {
            Debug.Log("win");
        }
    }
}
