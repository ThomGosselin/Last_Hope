using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public  List<ObjDesc> inventory;

    public GameObject objets;
    public ObjDesc description;
    bool objectToPickup = false;
    int invIndex = 0;

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
            if (Input.GetKeyDown(KeyCode.E))
            {
                objets.SetActive(false);
                addToInventory();
            }
        }
    }

    public void addToInventory()
    {
        Debug.Log(inventory.Count);
        inventory.Add(description);
        Debug.Log(inventory.Count);

    }
}
