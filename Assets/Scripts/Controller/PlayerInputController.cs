using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    private Camera _camera;


    private void Awake()
    {
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        Vector2 direction = (worldPos - (Vector2)transform.position).normalized;

        if (direction.magnitude >= 0.9f)
        {
            CallLookEvent(direction);
        }
    }

    public void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            CallJumpEvent(Vector2.up);
        }
    }
}
