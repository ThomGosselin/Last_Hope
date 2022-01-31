using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlLoad : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Level1Sound");   
    }

}
