using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public GameObject objectToMove;
    public bool isThereAcollision = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isThereAcollision = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isThereAcollision = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isThereAcollision)
        {
            objectToMove.transform.position = new Vector3(9.006f, 9.0699f, 0f);
            FindObjectOfType<AudioManager>().Play("moveObj");
        }
    }

}
