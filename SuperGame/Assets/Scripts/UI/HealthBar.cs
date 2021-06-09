using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private float _changeSpeed;

    private Slider _healthView;
    private float _newValue;
    private bool _finish = true;

    private void Start()
    {
        _healthView = GetComponent<Slider>();
        _healthView.value = 1;
        _newValue = _healthView.value;
    }

    public void ChangeBar(int value)
    {
        _newValue += (float)value / 100;

        if (_finish)
            StartCoroutine(ChangeBar());
    }

    private IEnumerator ChangeBar()
    {
        _finish = false;
        while (_healthView.value != _newValue)
        {
            _healthView.value = Mathf.MoveTowards(_healthView.value, _newValue, _changeSpeed * Time.deltaTime);

            yield return null;
        }
        _finish = true;
    }
}
