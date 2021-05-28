using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HeroLife : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private int _maxHealth;

    private int _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;    
    }

    public void ChangeHealth(int value)
    {
        if (_currentHealth + value <= _maxHealth)
        {
            _currentHealth += value;
            _healthBar.GetComponent<Bar>().ChangeBar(value);
        }

        if (_currentHealth <= 0)
            SceneManager.LoadScene(1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemySecurity>() != null)
        {
            ChangeHealth(-1 * collision.GetComponent<EnemySecurity>().Damage);
        }
    }
}
