using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class Menu : MonoBehaviour
{
    [SerializeField] private CanvasGroup _authorsInforamation;
    [SerializeField] private GameObject _hero;
    [SerializeField] private GameObject _camera;
    [SerializeField] private List<GameObject> _notMenuObjects;

    private CanvasGroup _menuGroup;

    private void Start()
    {
        _authorsInforamation.alpha = 0;
        _menuGroup = GetComponent<CanvasGroup>();

        _camera.transform.SetParent(transform);

        foreach (var gameObgect in _notMenuObjects)
        {
            gameObgect.SetActive(false);
        }
    }

    public void StartGame()
    {
        foreach (var gameObgect in _notMenuObjects)
        {
            gameObgect.SetActive(true);
        }

        _camera.transform.SetParent(_hero.transform);

        _menuGroup.gameObject.SetActive(false);
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
