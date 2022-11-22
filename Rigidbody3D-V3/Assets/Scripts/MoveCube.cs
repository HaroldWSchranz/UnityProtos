using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// https://www.youtube.com/watch?v=HmXU4dZbaMw
// In this tutorial, learn how a beginner can adapt their current project
// to use the new input system in a simple way, as well as using the more
// complicated C# Event driven way.
public class MoveCube : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 5f;
    public PlayerInputActions playerControls;

    Vector3 moveDirection = Vector3.zero;
    private InputAction move;
    private InputAction fire;

    [SerializeField] GameObject hitParticle;          //!< effects for  hits

    private void Awake()
    {
        playerControls = new PlayerInputActions();
    }

    // Enable/Disable input system
    private void OnEnable()
    {
        //playerControls.Enable();
        move = playerControls.Player.Move;
        move.Enable();

        fire = playerControls.Player.Fire;
        fire.Enable();
        fire.performed += Fire;
    }

    private void OnDisable()
    {
        //playerControls.Disable();
        move.Disable();
        fire.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        //float moveX = Input.GetAxis("Horizontal");
        //float moveY = Input.GetAxis("Vertical");
        //moveDirection = new Vector3(moveX, moveY, 0f).normalized;

        //moveDirection = playerControls.ReadValue<Vector2>();

        moveDirection = move.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3 (moveDirection.x*moveSpeed, moveDirection.y*moveSpeed, 0f);
    }

    private void Fire(InputAction.CallbackContext context)
    {
        Debug.Log("We fired");
        Instantiate(hitParticle, transform.position, Quaternion.identity);
    }
}
