using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public bool isInventoryOpen = false;
    public GameObject InventoryMenuUi;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (isInventoryOpen)
            {
                CloseInventory();
            }
            else
            {
                OpenInventory();
            
            }
        }
    }
    public void OpenInventory()
        {
            InventoryMenuUi.SetActive(true);
            Time.timeScale = 0f;
            isInventoryOpen = true;
        }
    public void CloseInventory()
    {
        InventoryMenuUi.SetActive(false);
        Time.timeScale = 1f;
        isInventoryOpen = false;
    }
}



