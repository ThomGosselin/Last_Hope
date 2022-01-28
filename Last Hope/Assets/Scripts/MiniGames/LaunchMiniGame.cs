using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchMiniGame : MonoBehaviour
{
    public GameObject CoffreFort;
    public GameObject MiniGame1;
    public GameObject player;
    public bool  isThereAcollision = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            isThereAcollision = true;
        }
    }

    private void FixedUpdate()
    {
        if (isThereAcollision == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                MiniGame1.SetActive(true);
                player.SetActive(false);
            }
        }
    }
}




