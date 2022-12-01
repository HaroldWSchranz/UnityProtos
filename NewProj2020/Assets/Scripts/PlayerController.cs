using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private InputActions1 inputActions;
    private InputAction movement;

    private void Awake()
    {
        inputActions = new InputActions1();
    }

    private void OnEnable()
    {
        movement = inputActions.Player.Movement;
        movement.Enable();

        inputActions.Player.Jump.performed += DoJump;
        inputActions.Player.Jump.Enable();
    }

    private void DoJump(InputAction.CallbackContext obj)
    {
        Debug.Log("Jump!!!");
    }

    private void OnDisable()
    {
        movement.Disable();
        inputActions.Player.Jump.Disable();
    }

    private void FixedUpdate()
    {
        Debug.Log("Movement Values " + movement.ReadValue<Vector2>());
    }

}
