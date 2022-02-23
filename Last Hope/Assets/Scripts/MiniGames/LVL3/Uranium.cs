using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uranium : MonoBehaviour
{
    public GameObject Etagere;
    public GameObject xBtn;
    public GameObject Player;
    public GameObject Ingrediant;


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
                Etagere.SetActive(false);
                Player.SetActive(true);
                xBtn.SetActive(false);
                Ingrediant.SetActive(true);
                FindObjectOfType<LastEnigmeManager>().Enigme3Complete = true;
                FindObjectOfType<AudioManager>().Play("SuccedMiniGame");

            }
        }
    }
}
