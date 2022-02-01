using System;
using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;
    public AudioSource lvlSounds;
    private bool isGamePaused = false;
    // Start is called before the first frame update
    void Awake()
    {

        foreach (Sound s in sounds)
        {
            s.source =gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }

       
    }

    


    // Update is called once per frame
    public void Play(string name)
    {
       Sound s = Array.Find(sounds, sound => sound.name == name);
        if(s == null)
        {
            return;
        }
       s.source.Play();
    }

    public void Pause(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                ClosePause();   
            }
            else
            {
                OpenPause(); 
            }
        }
    }

    private void OpenPause()
    {
        Debug.Log("pause");
        isGamePaused = true;
        lvlSounds.volume = 0;
        FindObjectOfType<AudioManager>().Play("Pause");
    }

    private void ClosePause()
    {
        Debug.Log("UnPause");
        isGamePaused = false;
        lvlSounds.volume = 1;
        FindObjectOfType<AudioManager>().Pause("Pause");
    }
}
