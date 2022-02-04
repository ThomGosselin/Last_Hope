using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchImg : MonoBehaviour
{

    public GameObject imgCadenas;
    public GameObject player;
    public GameObject xBtn;
    public BoxCollider2D hitbox;
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
            if (Input.GetKey(KeyCode.E))
            {
                imgCadenas.SetActive(true);
                xBtn.SetActive(true);
                player.SetActive(false);
                isThereAcollision = false;
            }
        }
    }
}
