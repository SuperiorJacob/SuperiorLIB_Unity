using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class sideMovement : MonoBehaviour
{
    public float speed = 6.0F;
    public float jumpHeight = 50.0F;
    public float gravity = 20.0F;

    private float xPos = 0f;
    private float yPos = 0f;

    private bool inAir = false;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        inAir = (transform.position.y != 0);

        xPos += Input.GetAxisRaw("Horizontal");
        yPos += Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector3(xPos * speed, rb.velocity.y, yPos * speed);
        
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z);
        }

        if (inAir)
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y - (gravity * Time.deltaTime), rb.velocity.z);

        xPos = 0;
        yPos = 0;
    }
}
