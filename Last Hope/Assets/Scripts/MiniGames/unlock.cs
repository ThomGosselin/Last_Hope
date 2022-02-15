using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlock : MonoBehaviour
{
    public string Code;
    public string userInputCode;
    public int nbrOfKey;
    public int currentNbrOfKey = 1;
    public GameObject gameGrid;
    public GameObject Xbtn;
    public GameObject Player;
    public GameObject UsbKey;
    public BoxCollider2D ComputerHitBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            AddLeft();
         
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            AddDown();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            AddUp();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            AddRight();
        }
    }

    public void AddLeft()
    {
        Debug.Log("Left");
        userInputCode = userInputCode + "left";
        currentNbrOfKey++;
        if (currentNbrOfKey== nbrOfKey)
        {
            checkUserCode();
        }
    }
    public void AddDown()
    {
        Debug.Log("Down");
        userInputCode = userInputCode + "down";
        currentNbrOfKey++;
        if (currentNbrOfKey == nbrOfKey)
        {
            checkUserCode();
        }
    }
    public void AddUp()
    {
        Debug.Log("Up");
        userInputCode = userInputCode + "up";
        currentNbrOfKey++;
        if (currentNbrOfKey == nbrOfKey)
        {
            checkUserCode();
        }
    }
    public void AddRight()
    {
        Debug.Log("Right");
        userInputCode = userInputCode + "right";
        currentNbrOfKey++;
        if (currentNbrOfKey == nbrOfKey)
        {
            checkUserCode();
        }
    }
    public void closeGame()
    {
        userInputCode = "";
        Debug.Log("end");
        Player.SetActive(true);
        gameGrid.SetActive(false);
        Xbtn.SetActive(false);
        UsbKey.SetActive(true);
        FindObjectOfType<AudioManager>().Play("SuccedMiniGame");
    }

    public void RestartGame()
    {
        userInputCode = "";
        currentNbrOfKey = 0;
        FindObjectOfType<AudioManager>().Play("ErrorMiniGame");
    }

    public void checkUserCode()
    {
        if (userInputCode == Code)
        {
            Debug.Log("got it");
            ComputerHitBox.isTrigger = true;
            closeGame();
        }
        else
        {
            RestartGame();
        }
    }
}
