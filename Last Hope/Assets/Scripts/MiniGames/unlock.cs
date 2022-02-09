using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlock : MonoBehaviour
{
    public string Code;
    public string userInputCode;
    public GameObject gameGrid;
    public GameObject Xbtn;
    public GameObject Player;

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
        if(userInputCode == Code)
        {
            Debug.Log("got it");
            closeGame();
        }
    }

    public void AddLeft()
    {
        Debug.Log("Left");
        userInputCode = userInputCode + "left";
    }
    public void AddDown()
    {
        Debug.Log("Down");
        userInputCode = userInputCode + "down";
    }
    public void AddUp()
    {
        Debug.Log("Up");
        userInputCode = userInputCode + "up";
    }
    public void AddRight()
    {
        Debug.Log("Right");
        userInputCode = userInputCode + "right";
    }
    public void closeGame()
    {
        userInputCode = "";
        Debug.Log("end");
    }
}
