using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2.5f;
    public Rigidbody2D rigidbody;
    public float force;
    public float minimalHeight;
    public bool isCheatMode;
    public GroundDetection groundDetection;
    private Vector3 direction;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    private bool isJumping;

    void FixedUpdate()
    {
        animator.SetBool("IsGrounded", groundDetection.isGrounded);
        if (!isJumping && !groundDetection.isGrounded)
        {
            animator.SetTrigger("StartFall");
        }
        isJumping = groundDetection.isGrounded;
        direction = Vector3.zero; // (0, 0)
        if (Input.GetKey(KeyCode.A))
        {
            direction = Vector3.left; // (-1, 0)
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction = Vector3.right; // (1, 0)
        }
       
        direction *= speed;
        direction.y = rigidbody.velocity.y;
        rigidbody.velocity = direction;
       
        if (Input.GetKeyDown(KeyCode.W) && groundDetection.isGrounded)
        {
            rigidbody.AddForce(Vector2.up * force, ForceMode2D.Impulse);
            animator.SetTrigger("StartJump");
            isJumping = true;
        }

        if(direction.x > 0)
        {
            spriteRenderer.flipX = false;
        }

        if (direction.x < 0)
        {
            spriteRenderer.flipX = true;
        }

        animator.SetFloat("Speed", Mathf.Abs(direction.x));

        CheckFall();
    
    }

    void CheckFall()
    {
        if (transform.position.y < minimalHeight && isCheatMode)
        {
            rigidbody.velocity = new Vector2(0, 0);
            transform.position = new Vector2(0, 0);
        }

        else if (transform.position.y < minimalHeight)
        {
            Destroy(gameObject);
        }
    }
}



