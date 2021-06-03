using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class HeroLife : MonoBehaviour
{
    [SerializeField] private int _maxHealth;

    private int _currentHealth;
    private EnemySecurity _enemy;

    public ChangeBarEvent ChangeBarEvent;

    private void Start()
    {
        _currentHealth = _maxHealth;    
    }

    public void ChangeHealth(int value)
    {
        if (_currentHealth + value <= _maxHealth)
        {
            _currentHealth += value;
            ChangeBarEvent.Invoke(value);
        }

        if (_currentHealth <= 0)
            SceneManager.LoadScene(1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _enemy = collision.GetComponent<EnemySecurity>();

        if (_enemy != null)
        {
            ChangeHealth(-1 * _enemy.Damage);
        }
    }
}

[System.Serializable]
public class ChangeBarEvent : UnityEvent<int> { }