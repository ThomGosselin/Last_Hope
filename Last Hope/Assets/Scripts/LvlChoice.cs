using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlChoice : MonoBehaviour
{
   public void GoToLvl1 ()
    {
        Loader.Load(Loader.Scene.Game_Level1);
    }
}
