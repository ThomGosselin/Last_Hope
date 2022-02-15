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

    void Update()
    {
        if (objectToPickup == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if( inventorySpaces.Length == 7)
                {
                    FindObjectOfType<AudioManager>().Play("InvFull");
                }
                else
                {
                    objets.SetActive(false);
                    Debug.Log(objets.name);
                    switch (objets.name)
                    {
                        case "Key1":
                            FindObjectOfType<LevelsManager>().key1Good = true;
                            break;
                        case "Key2":
                            FindObjectOfType<LevelsManager>().key2Good = true;
                            break;
                        case "Key3":
                            FindObjectOfType<LevelsManager>().key3Good = true;
                            break;
                        case "Key4":
                            FindObjectOfType<LevelsManager>().key4Good = true;
                            break;
                        case "Key5":
                            FindObjectOfType<LevelsManager>().key5Good = true;
                            break;
                        case "Key6":
                            FindObjectOfType<LevelsManager>().key6Good = true;
                            break;
                    }
                    FindObjectOfType<AudioManager>().Play("InvPick");
                    addToInventory();
                    objectToPickup = false;
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