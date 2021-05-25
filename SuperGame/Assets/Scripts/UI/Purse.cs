using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Purse : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    public void ShowPurse(int coin)
    {
        _text.text = coin.ToString();
    }
}
