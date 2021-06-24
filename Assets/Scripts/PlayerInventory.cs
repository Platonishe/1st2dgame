using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int coinsCount;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (gameObject.CompareTag("Player"))
        {
            if (col.gameObject.CompareTag("Coin"))
            {
                coinsCount++;
                Destroy(col.gameObject);
                Debug.Log("���������� ����� = " + coinsCount);
            }
        }
    }
}
