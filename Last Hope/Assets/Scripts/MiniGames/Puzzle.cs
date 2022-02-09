using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{

    public numberBox boxPrefab;

    public numberBox[,] boxes = new numberBox[4, 4];

    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        Init(); 
    }

    void Init()
    {
        int n = 0;
        for(int y = 3; y >= 0; y--)
        for(int x = 0; x < 4; x++)
            {
                numberBox box = Instantiate(boxPrefab, new Vector2(x, y), Quaternion.identity);
                box.Init(x, y, n + 1, sprites[n]);
                boxes[x, y] = box;
                n++;
            }


    }
}
