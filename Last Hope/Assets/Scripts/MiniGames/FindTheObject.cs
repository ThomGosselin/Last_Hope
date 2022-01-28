    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindTheObject : MonoBehaviour
{
    public GameObject GameGrid;
    public GameObject imgToFind;
    public GameObject player;
    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (!hit)
            {
                //son erreur minigame
                return;
            }
            if (hit.collider.CompareTag("ItemToFind"))
            {
                GameGrid.SetActive(false);
                player.SetActive(true);
            }
        }
        
    }
}
