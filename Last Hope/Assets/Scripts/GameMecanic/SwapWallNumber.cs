using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapWallNumber : MonoBehaviour
{
    public GameObject WallNoPaper;
    public GameObject WallYesPaper;

    public void Swap_Wall()
    {
        WallNoPaper.SetActive(false);
        WallYesPaper.SetActive(true);
    }
}
