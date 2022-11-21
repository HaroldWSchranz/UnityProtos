using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 100f;

    Vector3 moveDirection = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        
        moveDirection = new Vector3(moveX, moveY, 0f).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3 (moveDirection.x*moveSpeed, moveDirection.y*moveSpeed, 0f);
    }
}
