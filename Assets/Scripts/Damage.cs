using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    private int damage = 10;
    public int Uron
    {
        get { return damage; }
        set
        {
            if ( value > 10 )
            damage = value;
        }
    }
    public string collisionTag;
    private Health health;

    [SerializeField] private Animator enemyanimator;
    [SerializeField] private SpriteRenderer spriteRenderer;
    private float direction;
    
    public float Direction
    {
        get { return direction; }
    }

    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.CompareTag(collisionTag))
        {
            Health health = col.gameObject.GetComponent<Health>();
            if (health != null)
            {
                direction = (col.transform.position - transform.position).x;
                enemyanimator.SetFloat("Direction", Mathf.Abs(direction));
            }

        }
    }
    
    public void SetDamage()
    {
        if (health != null)
            health.TakeHit(damage);
        health = null;
        direction = 0;
        enemyanimator.SetFloat("Direction", 0f);
    }

}
