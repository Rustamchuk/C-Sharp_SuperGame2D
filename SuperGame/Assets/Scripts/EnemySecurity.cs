using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;

public class EnemySecurity : MonoBehaviour
{
    [SerializeField] private Vector3[] _wayPoints;
    [SerializeField] private float _speed = 1;
    [SerializeField] private int _damage;

    public AttackHero AttackHeroEvent;

    private void Start()
    {
        Tween way = transform.DOPath(_wayPoints, _speed, PathType.Linear).SetOptions(true);
        way.SetEase(Ease.Linear).SetLoops(-1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<HeroLife>() != null)
            AttackHeroEvent.Invoke(-1 * _damage);
    }

    [System.Serializable]
    public class AttackHero : UnityEvent<int> { }
}
