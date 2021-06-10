﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class HeroLife : MonoBehaviour
{
    [SerializeField] private int _maxHealth;

    private int _currentHealth;

    public GetDamageEvent GetDamage;

    private void Start()
    {
        _currentHealth = _maxHealth;    
    }

    public void ChangeHealth(int value)
    {
        if (_currentHealth + value <= _maxHealth)
        {
            _currentHealth += value;
            GetDamage.Invoke(value);
        }

        if (_currentHealth <= 0)
            SceneManager.LoadScene(1);
    }
}

[System.Serializable]
public class GetDamageEvent : UnityEvent<int> { }