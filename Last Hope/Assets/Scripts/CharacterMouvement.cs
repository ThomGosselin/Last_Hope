using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMouvement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rigidbody;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}