using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public ArrayList inventory;

    public GameObject objets;
    bool objectToPickup = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision");
        if (collision.CompareTag("Objets")){
            Debug.Log("C'est un objets");
            objectToPickup = true;


        }
    }

    private void FixedUpdate()
    {
        if (objectToPickup == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                objets.SetActive(false);
            }
        }
    }
}
