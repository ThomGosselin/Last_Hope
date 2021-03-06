using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindTheObject : MonoBehaviour
{
    public GameObject GameGrid;
    public GameObject imgToFind;
    public GameObject player;
    public GameObject itemKey1;
    public BoxCollider2D hitBox;
    public GameObject hitBox2;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider.CompareTag("ItemToFind"))
            {
                GameGrid.SetActive(false);
                player.SetActive(true);
                FindObjectOfType<AudioManager>().Play("SuccedMiniGame");
                itemKey1.SetActive(true);
                Destroy(hitBox);
                Destroy(hitBox2);
            }
            else
            {
                return;
            }
        }
        
    }
}
