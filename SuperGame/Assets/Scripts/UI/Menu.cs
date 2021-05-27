using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class Menu : MonoBehaviour
{
    [SerializeField] private CanvasGroup _authorsInforamation;
    [SerializeField] private GameObject _hero;

    private CanvasGroup _menuGroup;

    private void Start()
    {
        _authorsInforamation.alpha = 0;
        _menuGroup = GetComponent<CanvasGroup>();
    }

    public void StartGame()
    {
        _menuGroup.alpha = 0;
    }

    public void ShowAuthors()
    {
        _authorsInforamation.alpha = 1;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
