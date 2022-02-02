using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchImg : MonoBehaviour
{

    public GameObject imgCadenas;
    public GameObject player;
    public bool isThereAcollision = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isThereAcollision = true;
        }
    }

    private void FixedUpdate()
    {
        if (isThereAcollision == true)
        {
            Debug.Log("Jeu");
            if (Input.GetKey(KeyCode.E))
            {
                imgCadenas.SetActive(true);
                player.SetActive(false);
                isThereAcollision = false;

            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            imgCadenas.SetActive(false);
            player.SetActive(true);
        }
    }
}
