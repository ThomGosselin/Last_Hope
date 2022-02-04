using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchMiniGame : MonoBehaviour
{
    public GameObject MiniGame1;
    public GameObject player;
    public BoxCollider2D hitBox;
    public bool  isThereAcollision = false;
    private int temp;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if(collision.CompareTag("Player"))
        {
            Debug.Log(collision.tag);
            isThereAcollision = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        isThereAcollision = false;
    }

    private void FixedUpdate()
    {
        if (isThereAcollision == true)
        {
            Debug.Log("Jeu");
            if (Input.GetKey(KeyCode.E))
            {
                MiniGame1.SetActive(true);
                player.SetActive(false);
                temp = -3;
                isThereAcollision = false;
            }
        }
    }
}




