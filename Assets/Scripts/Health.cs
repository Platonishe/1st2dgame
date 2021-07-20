using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int health;
    public int Life
    {
        get { return health; }
        set
        {
            if ( value > 10 )
            health = value;
        }
    }

    public void TakeHit(int damage)
    {
        health -= damage;

        Debug.Log(health);

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void SetHealth(int bonusHealth)
    {
        health += bonusHealth;
    }

}