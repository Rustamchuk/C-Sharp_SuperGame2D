using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeHealthButton : MonoBehaviour
{
    [SerializeField] private GameObject _hero;

    public void ChangeValue(int value)
    {
        _hero.GetComponent<HeroLife>().ChangeHealth(value);
    }
}
