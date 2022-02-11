using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenApp : MonoBehaviour
{
    public GameObject currentComputerScreen;
    public GameObject appToOpen;
    public GameObject CameraToOpen;
    public GameObject xBtn;

    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider.CompareTag("icnWord"))
            {
                Debug.Log("word");
                currentComputerScreen.SetActive(false);
                appToOpen.SetActive(true);
                xBtn.SetActive(true);
            }
            if (hit.collider.CompareTag("icnCamera"))
            {
                Debug.Log("camera");
                currentComputerScreen.SetActive(false);
                CameraToOpen.SetActive(true);
                xBtn.SetActive(true);
            }
        }
    }
}
