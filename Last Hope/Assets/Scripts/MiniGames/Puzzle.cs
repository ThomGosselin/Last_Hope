using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{

    public numberBox boxPrefab;

    public GameObject parent;

    public numberBox[,] boxes = new numberBox[3, 3];
    public numberBox[,] Originalboxes = new numberBox[3, 3];


    public Sprite[] sprites;
    public numberBox oldSprite;
    private numberBox newSprite;
    [Header("Close Game Section")]
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject GameGrid;
    [SerializeField] private GameObject Xbtn;
    [SerializeField] private GameObject Key;
    [SerializeField] private BoxCollider2D hitbox;




    void Start()
    {
        Debug.Log(sprites);
        Init();
        for (int i = 0; i < 999; i++)
        {
            Shuffle();
        }
    }

    void Init()
    {
        int n = 0;
        for(int y = 2; y >= 0; y--)
        for(int x = 0; x < 3; x++)
            {
                numberBox box = Instantiate(boxPrefab, parent.transform);
                box.Init(x, y, n + 1, sprites[n], CLickToSwap );
                boxes[x, y] = box;
                Originalboxes = (numberBox[,])boxes.Clone();
                n++;
            }
    }
    void CLickToSwap(int x,int y)
    {
        int Dx = getDx(x, y);
        int Dy = getDy(x, y);
        Swap(x, y, Dx, Dy);
        checkWin();
       
    }

    void Swap(int x, int y, int Dx, int Dy)
    {
        var from = boxes[x, y];
        var target = boxes[x + Dx, y + Dy];

        //swap this 2 boxes
        boxes[x, y] = target;
        boxes[x + Dx, y + Dy] = from;

        //update pos 2 boxes;
        from.UpdatePos(x + Dx, y + Dy);
        target.UpdatePos(x, y);
    }

    int getDx(int x, int y)
    {
        //is right empty
        if (x < 2 && boxes[x + 1, y].isEmpty())
        {
            return 1;
        }
        //is left empty
        else if (x > 0 && boxes[x - 1, y].isEmpty())
        {
            return -1;
        }
        else
        {
            return 0;
        }
        
    }

    int getDy(int x, int y)
    {
        //is top empty
        if (y < 2 && boxes[x, y + 1].isEmpty())
        {
            return 1;
        }
        //is bottom empty
        else if (y > 0 && boxes[x, y - 1].isEmpty())
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }

    void Shuffle()
    {
        for(int i =0; i<3; i++)
        {
            for (int j =0; j<3; j++)
            {
                if (boxes[i, j].isEmpty())
                {
                    Vector2 pos = getValidMove(i, j);
                    Swap(i, j, (int)pos.x, (int)pos.y);

                }
            }
        }
    }

    private Vector2 lastMove;

    Vector2 getValidMove(int x, int y)
    {
        Vector2 pos = new Vector2();
        do
        {
            int n = Random.Range(0, 4);
            if (n == 0)
                pos = Vector2.left;
            else if (n == 1)
                pos = Vector2.right;
            else if (n == 2)
                pos = Vector2.up;
            else
                pos = Vector2.down;
        } while (!(isValidRange(x + (int)pos.x) && isValidRange(y + (int)pos.y)) || isRepeatMove(pos));

        lastMove = pos;
        return pos;
    }

    bool isValidRange(int n)
    {
        return n >= 0 && n <= 3;
    }

    bool isRepeatMove(Vector2 pos)
    {
        return pos * -1 == lastMove;
    }

    void checkWin()
    {
       for(int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (Originalboxes[i,j] != boxes[i, j])
                {
                    Debug.Log("je suis dans le if");
                    return;
                }
            }
        }
        player.SetActive(true);
        Key.SetActive(true);
        GameGrid.SetActive(false);
        Xbtn.SetActive(false);
        Destroy(hitbox);
        FindObjectOfType<AudioManager>().Play("SuccedMiniGame");

    }
}
