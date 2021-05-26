using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroDie : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<EnemySecurity>() != null)
        {
            Application.Quit();
            Time.timeScale = 0;
        }
    }
}
