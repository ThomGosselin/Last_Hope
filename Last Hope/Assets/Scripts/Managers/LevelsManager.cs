using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelsManager : MonoBehaviour
{
    public bool key1Good;
    public bool key2Good;
    public bool key3Good;
    public int lvl=0;


    public void Update()
    {
        if(key1Good && key2Good && key3Good)
        {
            Debug.Log("win");
            key1Good = false;
            key2Good = false;
            key3Good = false;
            switch (lvl)
            {
                case 0:
                    Debug.Log("cinematique1");
                    lvl = 1;
                    break;
                case 1:
                    Debug.Log("cinematique2");
                    lvl = 2;
                    break;
                case 2:
                    Debug.Log("cinematique3");
                    break;
            }
        }
    }
}
