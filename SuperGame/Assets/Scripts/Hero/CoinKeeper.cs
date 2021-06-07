using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinKeeper : MonoBehaviour
{
    [SerializeField] private Purse _purse;

    private int _coins;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Coin>() != null)
        {
            _coins++;
            Destroy(collision.gameObject);

            _purse.ShowPurse(_coins);
        }
    }
}
