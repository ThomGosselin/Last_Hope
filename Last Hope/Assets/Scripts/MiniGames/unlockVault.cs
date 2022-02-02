using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class unlockVault : MonoBehaviour
{
    public GameObject[] circleTab;
    public GameObject[] selectedCircleTab;
    public GameObject gameGrid;
    public float randomCircle;
    public int circleToRemember;
    public int i;
    public int oldNumber;
    public GameObject selectedCircle;
    public GameObject correctCircle;


    void Start()
    {
        StartCoroutine(waitForStartGames());
    }

    IEnumerator waitForStartGames()
    {
        yield return new WaitForSeconds(3);
        Debug.Log("start");
    }



    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider.CompareTag("selectedCricles"))
            {
                FindObjectOfType<AudioManager>().Play("SuccedMiniGame");
               hit.collider.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
            }
            else if( hit.collider.CompareTag("circles"))
            {
                FindObjectOfType<AudioManager>().Play("InvFull");
                hit.collider.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            }
        }
    }

}
