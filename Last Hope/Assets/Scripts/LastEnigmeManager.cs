using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastEnigmeManager : MonoBehaviour
{

    public bool Enigme1Complete = false;
    public bool Enigme2Complete = false;
    public bool Enigme3Complete = false;

    public GameObject mixTable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Enigme1Complete && Enigme2Complete && Enigme3Complete)
        {
            mixTable.SetActive(true);
        }
    }
}
