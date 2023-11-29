using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;

    private Vector2 _lookDirection = Vector2.zero;
    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;
    private Animator _animator;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
        _controller.OnJumpEvent += Jump;
        _controller.OnLookEvent += LookAt;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
        _animator.SetBool("IsMove", _movementDirection.magnitude > 0);

        UpdateDirection();
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;

        _rigidbody.velocity = direction;
    }

    private void Jump(Vector2 direction)
    {
        StartCoroutine(JumpRoutine());
    }

    private IEnumerator JumpRoutine()
    {
        _animator.SetBool("IsJump", true);
        yield return new WaitForSeconds(0.1f); // 점프 지속 시간
        _animator.SetBool("IsJump", false);
    }

    private void LookAt(Vector2 direction)
    {
        _lookDirection = direction;
    }

    private void UpdateDirection()
    {
        if (_movementDirection != Vector2.zero)
        {
            FlipCharacterDirection(_movementDirection.x);
        }
        else if (_lookDirection != Vector2.zero)
        {
            FlipCharacterDirection(_lookDirection.x);
        }
    }

    private void FlipCharacterDirection(float xDirection)
    {
        if (xDirection > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (xDirection < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}