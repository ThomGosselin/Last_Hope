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
    public bool toDestroyHitBox = false;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isThereAcollision = true;
        }
        if (collision.CompareTag("bureau"))
        {
            toDestroyHitBox = true;
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
            if (Input.GetKey(KeyCode.E))
            {
                imgCadenas.SetActive(true);
                player.SetActive(false);
                isThereAcollision = false;
                if (toDestroyHitBox)
                {
                    Destroy(hitbox);
                    
                }
            }
        }
    }
}
