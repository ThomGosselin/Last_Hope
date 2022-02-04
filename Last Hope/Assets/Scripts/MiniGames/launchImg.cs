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
        /*
        switch (collision.CompareTag())
        {
            case bureau:
                toDestroyHitBox = true; //a essayer de faire fonctionner
                break;
        }*/
        if (collision.CompareTag("bureau"))
        {
            toDestroyHitBox = true;
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
                if (toDestroyHitBox)
                {
                    Destroy(hitbox);
                }
            }
        }
    }
}
