using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LvlChoiceManager : MonoBehaviour
{

    public bool lvl1Complete;
    public bool lvl2Complete;
    public bool lvl3Complete;

    public int levelUnlock;


    public GameObject level2Btn;
    public GameObject level3Btn;

    public Image canvasBG;
    public Sprite lvl1Unlock;
    public Sprite lvl2Unlock;
    public Sprite lvl3Unlock;
    // Start is called before the first frame update
    void Start()
    {
        lvl1Complete = false;
        lvl2Complete = false;
        lvl3Complete = false;

        if (!PlayerPrefs.HasKey("levelProgress"))
        {
            PlayerPrefs.SetInt("levelProgress", 1);
            Load();
        }
        else
        {
            Load();
        }

    }


    private void Load()
    {
        levelUnlock = PlayerPrefs.GetInt("levelProgress");
        switch (levelUnlock)
        {
            case 1:
                canvasBG.sprite = lvl1Unlock;
                break;
            case 2:
                canvasBG.sprite = lvl2Unlock;
                level2Btn.SetActive(true);
                break;
            case 3:
                canvasBG.sprite = lvl3Unlock;
                level3Btn.SetActive(true);
                break;
        }
    }
}
