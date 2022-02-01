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
            Debug.Log("je suis la");
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
                if( inventorySpaces.Length == 7)
                {
                    Debug.Log("im full");
                    FindObjectOfType<AudioManager>().Play("InvFull");
                }
                else
                {
                    objets.SetActive(false);
                    FindObjectOfType<AudioManager>().Play("InvPick");
                    addToInventory();
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
                Debug.Log("ajout dans l'inventaire");
                imgObj.sprite = ObjEnContact.ObjIcon;
                break;
            }
        }
    }
}