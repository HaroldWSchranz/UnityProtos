using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float jumpSpeed = 10f;
    [SerializeField] Rigidbody2D rb;

    private float moveX;
    private float moveY;

    // Awake is called when loading
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal")*moveSpeed;
        moveY = Input.GetAxis("Vertical")*jumpSpeed;
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = moveX;
        velocity.y += moveY;
        rb.velocity = velocity;
    }
}
