using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed; // public --> shows up in inspector as editable property
    private Rigidbody rb;

    // called on first frame that script is active
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // performed before every frame calculation
    void Update()
    {
        
    }

    // performed before every physics calculation
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }
}
