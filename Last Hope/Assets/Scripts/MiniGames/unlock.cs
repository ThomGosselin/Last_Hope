using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlock : MonoBehaviour
{
    public string Code;
    public string userInputCode;
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
        }
    }

    public void AddLeft()
    {
        Debug.Log("Left");
    }
    public void AddDown()
    {
        Debug.Log("Left");
    }
    public void AddUp()
    {
        Debug.Log("Left");
    }
    public void AddRight()
    {
        Debug.Log("Left");
    }
}
