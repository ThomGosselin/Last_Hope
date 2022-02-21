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
    public bool key4Good;
    public bool key5Good;
    public bool key6Good;
    public bool Ingrediant1Good;
    public bool Ingrediant2Good;
    public bool Ingrediant3Good;
    public Image gameobject;
    private int levelUnlock;

    public void Update()
    {
        if(key1Good && key2Good && key3Good)
        {
            Debug.Log("win");
            key1Good = false;
            key2Good = false;
            key3Good = false;
            Debug.Log("cinematique1");
            levelUnlock = 2;
            PlayerPrefs.SetInt("levelProgress", levelUnlock);
            Loader.Load(Loader.Scene.CinematiqueLVL1To2);
        }
        if(key4Good && key5Good && key6Good)
        {
            Debug.Log("win2");
            key4Good = false;
            key5Good = false;
            key6Good = false;
            Debug.Log("cinematique2");
            levelUnlock = 3;
            PlayerPrefs.SetInt("levelProgress", levelUnlock);
            Loader.Load(Loader.Scene.CinemativeLvl2To3);
        }
    }
}
