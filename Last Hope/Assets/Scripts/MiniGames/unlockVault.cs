using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class unlockVault : MonoBehaviour
{
    public GameObject[] circleTab;
    public GameObject[] selectedCircleTab;
    public GameObject gameGrid;
    public int randomCircle;
    public int circleToRemember;
    public int i;
    public int oldNumber;
    public GameObject selectedCircle;
    public GameObject correctCircle;
    public int lifes;
    public int numberRange;

    void Start()
    {
        numberRange = circleTab.Length;
        GenerateRandomCircles();
    
            StartCoroutine(waitForStartGames());
    }

    IEnumerator waitForStartGames()
    {
        yield return new WaitForSeconds(3);
        for (i = 0; i < circleTab.Length; i++)
        {
            circleTab[i].gameObject.GetComponent<SpriteRenderer>().color = Color.white;

        }
            Debug.Log("start");
    }


    private void GenerateRandomCircles()
    {
        //generation d'un cercle random dans la grille de jeu
        for (i = 0; i < circleToRemember; i++)
        {
            randomCircle = Random.Range(1, circleTab.Length - 1);
            if (randomCircle == oldNumber)
            {
                i--;
            }
            else
            {
                Debug.Log(randomCircle);
                circleTab[randomCircle - 1].transform.gameObject.tag = "selectedCricles";
                circleTab[randomCircle - 1].gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
                oldNumber = randomCircle;
            }
           
        }
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(lifes != 0)
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

                RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
                if (hit.collider.CompareTag("selectedCricles"))
                {
                    FindObjectOfType<AudioManager>().Play("goodChoice");
                    hit.collider.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
                    circleTab[randomCircle - 1].transform.gameObject.tag = "selected";
                }
                else if (hit.collider.CompareTag("circles"))
                {
                    FindObjectOfType<AudioManager>().Play("badChoice");
                    hit.collider.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                    lifes = lifes - 1;
                }
                else if (!hit)
                {
                    return;
                }
            }
            else
            {
                gameGrid.SetActive(false);
                FindObjectOfType<AudioManager>().Play("ErrorMiniGame");
            }
        //code verification si le joueur a tout trouver 
        }
        
    }

}
