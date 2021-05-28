using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class Bar : MonoBehaviour
{
    [SerializeField] private float _changeSpeed;

    private Slider _bar;
    private float _currentValue;

    private void Start()
    {
        _bar = GetComponent<Slider>();
        _bar.value = 1;
        _currentValue = _bar.value;
    }

    private void Update()
    {
        if (_currentValue != _bar.value)
            _bar.value = Mathf.MoveTowards(_bar.value, _currentValue, _changeSpeed * Time.deltaTime);
    }

    public void ChangeBar(int value)
    {
        _currentValue = _bar.value + (float)value / 100;
    }
}
