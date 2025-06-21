using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (rb.gravityScale >= 1)
            {
                rb.gravityScale = -1f;
                jumpForce = -6f;
            }
            else
            {
                rb.gravityScale = 1;
                jumpForce = 6f;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("bbb"))
        {
            jumpForce = 0f;

        }
    }
        void OnTriggerExit2D(Collider2D other)
        {
        if (other.CompareTag("bbb"))
            {
            jumpForce = 7f;
    
            }
        }
}
