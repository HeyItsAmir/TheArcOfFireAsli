using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 5f;
    [SerializeField] public float rotationSpeed = 700f;
    private Rigidbody rb;

    void Start()
    {
        // Getting the Rigidbody component for physics-based movement
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        UseWASD();
    }

    void UseWASD()
    {
        // Getting joystick inputs for movement
        float horizontal = Input.GetAxis("Horizontal");  // Left/Right axis (A/D, Left Stick X on Android)
        float vertical = Input.GetAxis("Vertical");      // Up/Down axis (W/S, Left Stick Y on Android)

        // Moving the player based on input
        Vector3 move = new Vector3(horizontal, 0f, vertical) * moveSpeed * Time.deltaTime;
        rb.MovePosition(transform.position + move);

        // Rotating the player to face the movement direction
        if (move.magnitude > 0)
        {
            Quaternion targetRotation = Quaternion.LookRotation(move);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }

}