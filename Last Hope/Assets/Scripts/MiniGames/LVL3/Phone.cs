using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Phone : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("CodeBoiteVocal");
    }

    public void ReadMessage()
    {
        FindObjectOfType<AudioManager>().Play("MessageBoiteVocal");
    }
    
}
