using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{

    public float moveSpeed;
    public float rotateSpeed;
    Vector2 movement;

    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal") * rotateSpeed, Input.GetAxis("Vertical") * moveSpeed);

        transform.Rotate(Vector3.forward, -movement.x * Time.deltaTime);

    }

    void FixedUpdate()
    {
        //rb.MovePosition(transform.up * movement.y);

        rb.AddForce(transform.up * movement.y);
    }
}
