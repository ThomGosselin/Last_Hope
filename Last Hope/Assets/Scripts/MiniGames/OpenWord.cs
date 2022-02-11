using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenWord : MonoBehaviour
{
    public GameObject currentComputerScreen;
    public GameObject wordApplication;

    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider.CompareTag("icnWord"))
            {
                currentComputerScreen.SetActive(false);
                wordApplication.SetActive(true);
            }
        }
    }
}
