using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public GameObject leftBorder;
    public GameObject rightBorder;
    public Rigidbody2D rigidbody;
    public GroundDetection groundDetection;
    public bool isRightDirection;
    public float speed;
    public SpriteRenderer enemyspriteRenderer;
    public Animator enemyanimator;

    private void Start()
    {
        groundDetection = gameObject.GetComponent<GroundDetection>();
    }

    private void FixedUpdate()
    {
        if (isRightDirection)
        {
            rigidbody.velocity = Vector2.right * speed;
            if (transform.position.x > rightBorder.transform.position.x)
                isRightDirection = !isRightDirection;
            enemyspriteRenderer.flipX = true;
        }
        else if (groundDetection.isGrounded)
        {
            rigidbody.velocity = Vector2.left * speed;
            if (transform.position.x < leftBorder.transform.position.x)
                isRightDirection = !isRightDirection;
            enemyspriteRenderer.flipX = false;

        }

    }
}