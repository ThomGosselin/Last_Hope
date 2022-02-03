using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class unlockVault : MonoBehaviour
{
    public GameObject[] circleTab;
    public List<GameObject> selectedCircleTab;
    public GameObject gameGrid;
    public int randomCircle;
    public int circleToRemember;
    public int i;
    public int oldNumber;
    public GameObject selectedCircle;
    public GameObject correctCircle;
    public int lifes;
    public int numberRange;
    public GameObject itemKey1;
    public GameObject Player;
    public BoxCollider2D hitBox;

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
                circleTab[randomCircle - 1].transform.gameObject.tag = "selectedCricles";
                circleTab[randomCircle - 1].gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
                selectedCircleTab.Add(circleTab[randomCircle - 1]);
                Debug.Log(selectedCircleTab.Count);
                oldNumber = randomCircle;
            }

        }
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (lifes != 0)
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

                RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
                if (hit.collider.CompareTag("selectedCricles"))
                {
                    FindObjectOfType<AudioManager>().Play("goodChoice");
                    hit.collider.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
                    selectedCircleTab.Remove(hit.collider.gameObject);
                    if (selectedCircleTab.Count == 0) {
                        gameGrid.SetActive(false);
                        Player.SetActive(true);
                        FindObjectOfType<AudioManager>().Play("SuccedMiniGame");
                        itemKey1.SetActive(true);
                        Destroy(hitBox);

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
                    Player.SetActive(true);
                }

            }

        }

    }
}
