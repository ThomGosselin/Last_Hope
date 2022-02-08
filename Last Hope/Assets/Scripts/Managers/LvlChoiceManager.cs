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

    // Update is called once per frame
    void Update()
    {
        if (lvl1Complete)
        {
            levelUnlock = 2;
            Save();
        }
        else if (lvl2Complete)
        {
            levelUnlock = 3;
            Save();
        }
    }



    private void Save()
    {
        PlayerPrefs.SetFloat("levelProgress", levelUnlock);
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
                break;
            case 3:
                canvasBG.sprite = lvl3Unlock;
                break;
        }
    }
}
