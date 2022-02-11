using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public GameObject objectToMove;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            objectToMove.transform.position = new Vector3(9.006f, 9.0699f, 0f);
        }
    }

}
