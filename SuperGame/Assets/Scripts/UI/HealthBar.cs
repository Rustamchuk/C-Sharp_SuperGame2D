using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private float _changeSpeed;

    private Slider _healthBar;
    private float _newValue;

    private void Start()
    {
        _healthBar = GetComponent<Slider>();
        _healthBar.value = 1;
        _newValue = _healthBar.value;
    }

    public void StartChangeBar(int value)
    {
        _newValue += (float)value / 100;

        StartCoroutine(ChangeBar(_newValue));
    }

    private IEnumerator ChangeBar(float value)
    {
        while (_healthBar.value != _newValue)
        {
            _healthBar.value = Mathf.MoveTowards(_healthBar.value, _newValue, _changeSpeed * Time.deltaTime);

            yield return null;
        }
    }
}
