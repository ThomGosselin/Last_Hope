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
    public Image gameobject;
    public int lvl=0;
    private int levelUnlock;

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
                    levelUnlock = 2;
                    PlayerPrefs.SetFloat("levelProgress", levelUnlock);
                    lvl = 1;
                    //code qui sauvegarde le playerpref des niveau debloquer avec le save & le load
                    break;
                case 1:
                    Debug.Log("cinematique2");
                    levelUnlock = 3;
                    PlayerPrefs.SetFloat("levelProgress", levelUnlock);
                    lvl = 2;
                    break;
                case 2:
                    Debug.Log("cinematique3");
                    break;
            }
            Loader.Load(Loader.Scene.TempSceneAfterLevel1);
        }
    }
}
