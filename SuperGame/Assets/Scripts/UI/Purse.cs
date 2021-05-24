using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Purse : MonoBehaviour
{
    [SerializeField] private GameObject _hero;
    [SerializeField] private TMP_Text _text;

    private void Update()
    {
        _text.text = _hero.GetComponent<HeroLife>().Coins.ToString();
        Debug.Log($"{_hero.GetComponent<HeroLife>().Coins}");
    }
}
