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
    [SerializeField] private Animator enemyanimator;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag(collisionTag))
        {
            Health health = col.gameObject.GetComponent<Health>();
            health.TakeHit(damage);
            enemyanimator.SetTrigger("IsTouch");
        }
       


    }
}
