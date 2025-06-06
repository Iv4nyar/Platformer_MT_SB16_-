using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float chaseSpeed = 2f;
    public float jumpForce = 2f;
    public LayerMask Ground;
    private Rigidbody2D rb;
    private bool isGrounded;
    private bool shouldJump;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 1f, Ground);
        float direction = Mathf.Sign(player.position.x - transform.position.x);
        bool isPlayerAbove = Physics2D.Raycast(transform.position, Vector2.up, 3f, 1 << player.gameObject.layer);
        if (isGrounded)
        {
            rb.velocity = new Vector2(direction * chaseSpeed, rb.velocity.y);
            RaycastHit2D GroundInFront = Physics2D.Raycast(transform.position, new Vector2(direction, 0), 2f, Ground);
            RaycastHit2D gapAhead = Physics2D.Raycast(transform.position + new Vector3(direction, 0, 0), Vector2.down, 2f, Ground);
            RaycastHit2D platformAbove = Physics2D.Raycast(transform.position, Vector2.up, 3f, Ground);
            if (!GroundInFront.collider && !gapAhead.collider)
            {
                shouldJump = true;
            }
            else if (isPlayerAbove && platformAbove.collider)
            {
                shouldJump = true;
            }
        }
    }
    private void FixedUpdate()
    {
        shouldJump = false;
        Vector2 direction = (player.position - transform.position).normalized;

        Vector2 JumpDirection = direction * jumpForce;
        rb.AddForce(new Vector2(JumpDirection.x, jumpForce), ForceMode2D.Impulse);
    }
}
