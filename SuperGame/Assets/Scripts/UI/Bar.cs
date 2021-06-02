using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class Bar : MonoBehaviour
{
    [SerializeField] private float _changeSpeed;

    private Slider _bar;
    private float _newValue;

    private void Start()
    {
        _bar = GetComponent<Slider>();
        _bar.value = 1;
    }

    public void StartChangeBar(int value)
    {
        _newValue = _bar.value + (float)value / 100;

        StopAllCoroutines();
        StartCoroutine(ChangeBar(_newValue));
    }

    private IEnumerator ChangeBar(float value)
    {
        while (_bar.value != _newValue)
        {
            _bar.value = Mathf.MoveTowards(_bar.value, _newValue, _changeSpeed * Time.deltaTime);

            yield return null;
        }
    }
}
