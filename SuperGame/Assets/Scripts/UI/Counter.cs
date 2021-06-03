using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class Counter : MonoBehaviour
{
    [SerializeField] private float _changeSpeed;

    private Slider _counter;
    private float _newValue;

    private void Start()
    {
        _counter = GetComponent<Slider>();
        _counter.value = 1;
    }

    public void StartChangeBar(int value)
    {
        _newValue = _counter.value + (float)value / 100;

        StartCoroutine(ChangeBar(_newValue));

        StopCoroutine(ChangeBar(_newValue));
    }

    private IEnumerator ChangeBar(float value)
    {
        while (_counter.value != _newValue)
        {
            _counter.value = Mathf.MoveTowards(_counter.value, _newValue, _changeSpeed * Time.deltaTime);

            yield return null;
        }
    }
}
