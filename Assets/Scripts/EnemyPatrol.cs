using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public GameObject leftBorder;
    public GameObject rightBorder;
    public Rigidbody2D rigidbody;
    public GroundDetection groundDetection;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Damage damage;


    private bool isRightDirection;
    public bool IsRightDirection
    {
        get { return isRightDirection; }
        set
        {
            if (value = true)
                isRightDirection = value;
        }
    }
    private float speed;
    public float Speed
    {
        get { return speed; }
        set
        {
            if (value > 1.2f)
                speed = value;
        }
    }
    public SpriteRenderer enemyspriteRenderer;
    public Animator enemyanimator;

    private void Start()
    {
        groundDetection = gameObject.GetComponent<GroundDetection>();
    }

    private void FixedUpdate()
    {
       if (groundDetection.isGrounded)
       {
            if (transform.position.x > rightBorder.transform.position.x || damage.Direction < 0)
                isRightDirection = false;
            else if (transform.position.x < leftBorder.transform.position.x || damage.Direction > 0)
                isRightDirection = true;
            rigidbody.velocity = isRightDirection ? Vector2.right : Vector2.left;
            rigidbody.velocity *= speed;
            
       }
        
        if (rigidbody.velocity.x > 0)
        {
            spriteRenderer.flipX = true;
        }
        
        if (rigidbody.velocity.x < 0)
        {
            spriteRenderer.flipX = false;
        }
        


    }
}