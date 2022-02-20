using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlChoice : MonoBehaviour
{
    public void GoToLvl1()
    {
        Loader.Load(Loader.Scene.CinematiqueLVL1);
    }

    public void GoToLvl2()
    {
       Loader.Load(Loader.Scene.CinematiqueLVL1To2);
    }

    public void goToLvl3()
    {
     Loader.Load(Loader.Scene.CinematiqueLvl2To3);
    }
}