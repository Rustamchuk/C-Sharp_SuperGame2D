using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemySecurity : MonoBehaviour
{
    [SerializeField] private Vector3[] _wayPoints;
    [SerializeField] private float _speed = 1;

    private void Start()
    {
        Tween way = transform.DOPath(_wayPoints, _speed, PathType.Linear).SetOptions(true);
        way.SetEase(Ease.Linear).SetLoops(-1);
    }
}
