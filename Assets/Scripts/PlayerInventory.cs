using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private int coinsCount;

    public int CoinsCount
    {
        get { return coinsCount; }
        set
        {
            if ( value > 1 )
            coinsCount = value;
        }
    }

    public void Awake()
    {
        Instance = this;
    }

    public static PlayerInventory Instance { get; set; }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (gameObject.CompareTag("Player"))
        {
            if (col.gameObject.CompareTag("Coin"))
            {

                PlayerInventory.Instance.coinsCount++;
                Destroy(col.gameObject);
                Debug.Log("Количество монет = " + coinsCount);
            }
        }
    }
}
