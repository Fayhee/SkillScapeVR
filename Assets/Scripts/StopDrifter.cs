using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopDrifter : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision was with an object that has a collider
        if (collision.collider != null)
        {
            // Stop the player object from drifting by setting its velocity to zero
            rb.velocity = Vector3.zero;
        }
    }
}
