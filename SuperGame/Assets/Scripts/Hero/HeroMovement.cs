using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 6;
    [SerializeField] private float _jumpForce = 3;

    private bool _facingRight = true;
    private Rigidbody2D _hero;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _hero = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            if (_facingRight == false)
            {
                Vector3 face = transform.localScale;
                face.x *= -1;
                transform.localScale = face;
                _facingRight = !_facingRight;
            }

            transform.Translate(_speed * Time.deltaTime, 0, 0);
            TurnOnRun(_speed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (_facingRight)
            {
                Vector3 face = transform.localScale;
                face.x *= -1;
                transform.localScale = face;
                _facingRight = !_facingRight;
            }

            transform.Translate(_speed * -1 * Time.deltaTime, 0, 0);
            TurnOnRun(_speed);
        }
        else
        {
            TurnOnRun(0);
        }

        RaycastHit2D[] result = new RaycastHit2D[1];
        var ground = _hero.Cast(transform.up * -1, result, 0.1f);

        if (Input.GetKeyDown(KeyCode.Space) && ground != 0)
        {
            _animator.SetTrigger("Jump");
            _hero.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Impulse);
        }
    }

    private void TurnOnRun(float speed)
    {
        _animator.SetFloat("Speed", speed);
    }
}
