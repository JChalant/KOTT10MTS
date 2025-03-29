using System.Collections;           // JC added
using System.Collections.Generic;   // JC added
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0; // Ensure no gravity affects the player
    }

    void Update()
    {
        // Get input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Normalize movement to prevent faster diagonal movement
        movement = movement.normalized * moveSpeed * Time.fixedDeltaTime;

        // Attempt to move in horizontal direction first
        if (movement.x != 0)
        {
            Vector2 newPosition = rb.position + new Vector2(movement.x, 0);
            if (!CheckCollision(newPosition))
            {
                rb.MovePosition(newPosition);
            }
        }

        // Attempt to move in vertical direction
        if (movement.y != 0)
        {
            Vector2 newPosition = rb.position + new Vector2(0, movement.y);
            if (!CheckCollision(newPosition))
            {
                rb.MovePosition(newPosition);
            }
        }
    }

    bool CheckCollision(Vector2 targetPosition)
    {
        // Check if the new position would collide with anything
        Collider2D hit = Physics2D.OverlapCircle(targetPosition, 0.1f, ~LayerMask.GetMask("Player"));
        return hit != null;
    }
}