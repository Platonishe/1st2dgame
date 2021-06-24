using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Med : MonoBehaviour
{
    public int bonusHealth;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Health health = col.gameObject.GetComponent<Health>();
            health.SetHealth(bonusHealth);
            Destroy(gameObject);
        }
        
    }
}
