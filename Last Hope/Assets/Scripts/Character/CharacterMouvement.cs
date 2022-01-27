using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMouvement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rigidbody;
    public Animator animator;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        if (movement.x != 0)
        {
            animator.SetFloat("HorizontalIDLE", movement.x);
            animator.SetFloat("VerticalIDLE", 0);
        }
        if (movement.y != 0)
        {
            animator.SetFloat("VerticalIDLE", movement.y);
            animator.SetFloat("HorizontalIDLE", 0);
        }
    }

    void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
