using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject BigMap;
    public GameObject Etagere;
    public GameObject xBtnMap;
    public GameObject xBtnEtagere;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (!hit)
            {
                return;
            }
            if (hit.collider.CompareTag("ClickMap"))
            {
                BigMap.SetActive(false);
                Etagere.SetActive(true);
                xBtnMap.SetActive(false);
                xBtnEtagere.SetActive(true);
                FindObjectOfType<AudioManager>().Play("SuccedMiniGame");
            }
        }
    }
}
