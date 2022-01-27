using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    
    public  List<ObjDesc> inventory;
    public  Image[] inventorySpaces;

    public GameObject[] pickableItems;
    public List<GameObject> objets;
    public GameObject invUI;
    public ObjDesc description;
    public GameObject Obj1;
    public GameObject Obj2;
    public GameObject Obj3;
    public GameObject Obj4;
    public GameObject Obj5;
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
        inventorySpaces = invUI.GetComponentsInChildren<Image>();
        Debug.Log(pickableItems);
    }

    private void FixedUpdate()
    {
        if (objectToPickup == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log(description.ObjIndex);
                DetItem();
            }
        }
    }

    public void DetItem()
    {
        switch (description.ObjIndex)
        {
            case 1:
                Debug.Log("1");
                objets.Add(Obj1);
                Obj1.SetActive(false);
                break;
            case 2:
                objets.Add(Obj2);
                Obj2.SetActive(false);
                break;
        }
    }

    public void addToInventory()
    {
        Debug.Log(inventory.Count);
        inventory.Add(description);
        Debug.Log(inventory.Count);
        Debug.Log(description.ObjIcon);

        foreach (Image imgObj in inventorySpaces)
        {
            if (imgObj.sprite == null)
            {
                imgObj.sprite = description.ObjIcon;
                break;
            }
        }
    }

    public void AddToUI()
    {
        Debug.Log("test");
    }
}
