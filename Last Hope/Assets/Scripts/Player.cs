using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }

    private Inventory inventory;

    private void Awake()
    {
        new Inventory();
    }
}

