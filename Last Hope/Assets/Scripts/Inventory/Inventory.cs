using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<ObjDesc> inventory;
    public Image[] inventorySpaces;

    public GameObject invUI;
    public ObjDesc description;
    public ObjDesc ObjEnContact;
    public GameObject objets;
    bool objectToPickup = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        objets = collision.gameObject;
        ObjEnContact = collision.gameObject.GetComponent<ObjDesc>();
        if (collision.CompareTag("Objets"))
        {
            objectToPickup = true;
        }
    }

    private void Start()
    {
        inventorySpaces = invUI.GetComponentsInChildren<Image>();
    }

    private void FixedUpdate()
    {
        if (objectToPickup == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if(inventory.Count != 7)
                {
                    objets.SetActive(false);
                    addToInventory();
                }
                else
                {
                    //ajouter code pour item plein (bruitage);
                }
            }
        }
    }

    public void addToInventory()
    {
        inventory.Add(ObjEnContact);

        foreach (Image imgObj in inventorySpaces)
        {
            if (imgObj.sprite == null)
            {
                imgObj.sprite = ObjEnContact.ObjIcon;
                break;
            }
        }
    }
}