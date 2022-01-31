using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLvl1 : MonoBehaviour
{
    [SerializeField] AudioSource LvlSound;
    [SerializeField] AudioSource PauseSound;
    [SerializeField] AudioSource InvError;
    [SerializeField] AudioSource MiniGameSucces;
    [SerializeField] AudioSource MiniGameFail;

    private void Awake()
    {
        LvlSound.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
