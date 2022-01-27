    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindTheObject : MonoBehaviour
{

    public Sprite imgToFind;
    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Click");
            if (imgToFind.CompareTag("ItemToFind"))
            {
                Debug.Log("Bingo!");
            }
        }
    }
}
