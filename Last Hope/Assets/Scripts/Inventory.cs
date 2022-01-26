using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public  List<ObjDesc> inventory;
    public  Component[] inventorySpaces;

    public GameObject objets;
    public GameObject invUI;
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

    private void Start()
    {
        inventorySpaces = GetComponentsInChildren<Image>();

        foreach (Image imgObj in inventorySpaces)
        {
            Debug.Log("je suis un inventaire");
            Debug.Log(imgObj.sprite);
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
